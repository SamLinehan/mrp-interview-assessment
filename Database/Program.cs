using System;
using Microsoft.EntityFrameworkCore;
using Database.Data;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new UserContext())
            {
                db.Database.Migrate();
                DbInitializer.Initialize(db);

			}

			Console.ReadKey();

		}
    }
}
