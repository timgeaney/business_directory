namespace CA3_D10120047.Migrations
{
    using CA3_D10120047.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<CA3_D10120047.Models.CA3_D10120047Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CA3_D10120047.Models.CA3_D10120047Db context)
        {
           context.Businesses.AddOrUpdate(r => r.Name,
            new Business 
                {
                    Name = "Champion Sports", 
                    City = "Dublin", 
                    Country = "Ireland",
                    Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="tim"}
                    }
                },

            new Business
            {
                Name = "McDonalds",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="Emma"}
                    }
            },
            new Business
            {
                Name = "XGames",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="Alison"}
                    }
            },
            new Business
            {
                Name = "Vicar Street",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="tim"}
                    }
            },
            new Business
            {
                Name = "Global Mega Corp",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="david"}
                    }
            },
            new Business
            {
                Name = "Microsoft",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="jeff"}
                    }
            },
            new Business
            {
                Name = "Apple",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="sarah"}
                    }
            },
            new Business
            {
                Name = "Yahoo",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="Ali"}
                    }
            },
            new Business
            {
                Name = "IBM",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="tom"}
                    }
            },
            new Business
            {
                Name = "SAP",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="jeff"}
                    }
            },
            new Business
            {
                Name = "EBay",
                City = "Dublin",
                Country = "Ireland",
                Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 7, Body = "Whats up Doc!", ReviewerName="fred"}
                    }
            },
            new Business 
                {
                    Name = "The Point Depot", 
                    City = "Dublin", 
                    Country = "Ireland",
                    Reviews = new List<BusinessReview> {
                    new BusinessReview{ Rating = 9, Body = "Whats up Doc!", ReviewerName="tim"}
                    }
                });

          
           SeedMembership();

        }

        private void SeedMembership()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId",
                    "UserName", autoCreateTables: true);
            }

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }
            if (membership.GetUser("timgeaney", false) == null)
            {
                membership.CreateUserAndAccount("timgeaney", "password");
            }
            if (!roles.GetRolesForUser("timgeaney").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "timgeaney" }, new[] { "admin" });
            }

        }
    }
}
