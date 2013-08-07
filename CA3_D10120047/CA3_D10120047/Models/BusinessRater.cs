using CA3_D10120047.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA3_D10120047.Tests.Features
{
    class BusinessRater
    {
        private Business _business;

        public BusinessRater(Business business)
        {
            this._business = business;
        }

        public RatingResult ComputeRating()
        {
            var result = new RatingResult();
            result.Rating = (int)_business.Reviews.Average(b => b.Rating);
            return result;
        }
    }
}
