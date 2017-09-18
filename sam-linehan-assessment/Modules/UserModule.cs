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

			Post("/add", args =>
			{
				var userModel = this.Bind<Database.Models.User>();
                return "";
			});

            Delete("/delete/{id}", args => 
            {
                return "";
            });

            Get("/{id}", args =>
            {
                int userId = args.id;
                var query = from user in _context.Users
                            where user.Id == userId
                            select user;

                var result = JsonConvert.SerializeObject(query);
                return result;
            });


            Get("/list", async args =>
            {

                var result = await GetListAsync();
                return JsonConvert.SerializeObject(result);
            });

        }

        public async Task<IEnumerable<Database.Models.User>> GetListAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
