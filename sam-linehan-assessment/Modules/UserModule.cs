using System;
using Nancy;
using Nancy.ModelBinding;
using Database;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sam_linehan_assessment.Modules
{
    public class UserModule : NancyModule
    {
        private UserContext _context;

        public UserModule(UserContext context) : base("/user")
        {
            _context = context;

            Post("/add", async args =>
			{
                Database.Models.User newUser = this.Bind<Database.Models.User>();
                var result = await AddUserAsync(newUser);
                return result;
			});

            Delete("/delete/{id}", async args => 
            {
                int userId = args.id;
                var result = await DeleteUserAsync(userId);

                return result;
            });

            Get("/{id}", async args =>
            {
                int userId = args.id;
                var result = await GetUserAsync(userId);

                return result;
            });


            Get("/list", async args =>
            {

                var result = await GetListAsync();
                return JsonConvert.SerializeObject(result);
            });

        }

        public async Task<string> AddUserAsync(Database.Models.User user)
        {
            var name = user.First + " " + user.Last;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return "Added User: " + name;
        }

        public async Task<string> DeleteUserAsync(int id)
        {
            Database.Models.User userToDelete = await _context.Users.FindAsync(id);
            var name = userToDelete.First + " " + userToDelete.Last;

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return "Deleted User: " + name;
        }

		public async Task<Database.Models.User> GetUserAsync(int id)
		{
			return await _context.Users.FindAsync(id);
		}

        public async Task<IEnumerable<Database.Models.User>> GetListAsync()
        {
            return await _context.Users.ToListAsync();
        }

    }
}
