using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Database.Models;

namespace Database.Data
{
    public static class DbInitializer
    {

        public static void Initialize(UserContext context)
        {
            if(context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User {First = "ellie", Last= "fleming", Email = "ellie.fleming@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/women/44.jpg"},
                new User {First = "maria", Last= "jäger", Email = "maria.jäger@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/women/38.jpg"},
                new User {First = "byron", Last= "little", Email = "byron.little@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/men/81.jpg"},
                new User {First = "elias", Last= "koistinen", Email = "elias.koistinen@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/men/88.jpg"},
                new User {First = "eduartino", Last= "santos", Email = "eduartino.santos@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/men/22.jpg"},
                new User {First = "freya", Last= "thomas", Email = "freya.thomas@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/women/49.jpg"},
                new User {First = "cristian", Last= "suarez", Email = "cristian.suarez@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/men/78.jpg"},
                new User {First = "cassandra", Last= "dumas", Email = "cassandra.dumas@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/women/28.jpg"},
                new User {First = "derek", Last= "jimenez", Email = "derek.jimenez@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/men/13.jpg"},
                new User {First = "lena", Last= "schlegel", Email = "lena.schlegel@example.com", PictureUrl = "https://randomuser.me/api/portraits/thumb/women/28.jpg"}

            };

            foreach(User u in users){
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
    }
}
