using System;
using Microsoft.EntityFrameworkCore;
using Database.Data;
using System.Linq;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new UserContext())
            {
                db.Database.Migrate();
				Console.WriteLine("hello");
                DbInitializer.Initialize(db);

                var query = from u in db.Users
                            orderby u.First
                            select u;

                foreach (var item in query)
                {
                    Console.Write(item.First);
                }
			}

			Console.ReadKey();

		}
    }
}
