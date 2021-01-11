using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Reza",
                    Email = "ashena.reza@gmail.com",
                    UserName = "ashena.reza@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Reza",
                        LastName = "Ashena",
                        Street = "10 Main Street",
                        City="Toronto",
                        State = "ON",
                        ZipCode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "P@ssw0rd");
            }
        }
    }
}
