using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA3_D10120047.Models
{
    public class BusinessListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CountOfReviews { get; set; }
        public int AverageRating { get; set; }
        public virtual ICollection<BusinessReview> Reviews { get; set; }


    }
}