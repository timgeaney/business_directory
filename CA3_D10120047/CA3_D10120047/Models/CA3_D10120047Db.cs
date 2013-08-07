using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CA3_D10120047.Models
{
    public interface ICA3_D10120047Db : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    }

    public class CA3_D10120047Db : DbContext, ICA3_D10120047Db
    {
        public CA3_D10120047Db()
            : base("name=DefaultConnection")
        { 

        }

        public DbSet <UserProfile> UserProfiles{ get; set; }
        public DbSet <Business> Businesses { get; set; }
        public DbSet <BusinessReview> Reviews{ get; set; }
        public DbSet <RatingResult> Ratings { get; set; }

        IQueryable<T> ICA3_D10120047Db.Query<T>()
        {
            return Set<T>();
        }
    }
}