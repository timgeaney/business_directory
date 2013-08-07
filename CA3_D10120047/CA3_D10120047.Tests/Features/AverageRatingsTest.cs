using System;
using CA3_D10120047.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/* Add a test to check the average rating is correct
 * The average rating is to be a whole number and is the 
 * sum of the ratings divided by thetotal number of ratings
 * First test for one revies
 * Second test for more than one review
 * */


namespace CA3_D10120047.Tests.Features
{
    [TestClass]
    public class AverageRatingsTest
    {
        [TestMethod]
        public void Test_For_One_Review()
        {
            var data = new Business();
            data.Reviews = new List<BusinessReview>();
            data.Reviews.Add(new BusinessReview() { Rating = 4 });

            var rater = new BusinessRater(data);
            var result = rater.ComputeRating();

            Assert.AreEqual(4, result.Rating);

        }


        [TestMethod]
        public void Test_For_Three_Reviews()
        {
            var data = new Business();
            data.Reviews = new List<BusinessReview>();
            data.Reviews.Add(new BusinessReview() { Rating = 4 });
            data.Reviews.Add(new BusinessReview() { Rating = 7 });
            data.Reviews.Add(new BusinessReview() { Rating = 10 });

            var rater = new BusinessRater(data);
            var result = rater.ComputeRating();

            Assert.AreEqual(7, result.Rating);

          

        }


    }
}
