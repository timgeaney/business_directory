using CA3_D10120047.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_D10120047.Tests
{
    class TestData
    {
        public static IQueryable<Business> Business
        {
            get
            {
                var businesses = new List<Business>();
                for (int i = 0; i < 100; i++)
                {
                    var business = new Business();
                    business.Reviews = new List<BusinessReview>()
                    {
                        new BusinessReview {Rating = 6}

                    };
                    businesses.Add(business);
                }
                return businesses.AsQueryable();
            }
        }
    }
}
