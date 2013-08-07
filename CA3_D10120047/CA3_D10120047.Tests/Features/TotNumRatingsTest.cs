using CA3_D10120047.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Add a test to check the number of reviews returned is correct
 * */


namespace CA3_D10120047.Tests.Features
{
    class TotNumRatingsTest
    {
        [TestClass]
        public class AverageRatingsTest
        {
            [TestMethod]
            public void Test_Count_Num_Reviews()
            {
                var data = new Business();
                data.Reviews = new List<BusinessReview>();
                data.Reviews.Add(new BusinessReview() );
                data.Reviews.Add(new BusinessReview() );
                data.Reviews.Add(new BusinessReview() );
                
                
                var result = data.Reviews.Count();

                Assert.AreEqual(3, result);

            }
        }
    }
}
