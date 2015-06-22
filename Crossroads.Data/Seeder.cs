using Crossroads.Data.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Crossroads.Data
{
    class Seeder
    {
        public static void Seed(ApplicationDbContext db, bool users = false)
        {
            if (users) SeedUsers(db);
        }

        private static void SeedUsers(ApplicationDbContext db)
        {
            const string UserName = "MP";
            const string UserName2 = "Chadwick";

            var store = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(store);

            var hasher = new PasswordHasher();

            var user = new ApplicationUser
            {
                UserName = UserName,
                PasswordHash = hasher.HashPassword(UserName),
                Email = "morey269@gmail.com",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var user2 = new ApplicationUser
            {
                UserName = UserName2,
                PasswordHash = hasher.HashPassword(UserName2),
                Email = "test@fakemail.com",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            if (!db.Users.Any(x => x.Id == user.Id))
            {
                db.Users.Add(user);
                userManager.AddClaim(user.Id, new Claim("Godmode", "true"));
            }

            if (!db.Users.Any(x => x.Id == user2.Id))
            {
                db.Users.Add(user2);
                userManager.AddClaim(user.Id, new Claim("CanEditOwned", "true"));
            }

            db.SaveChanges();

        }

    }
}
