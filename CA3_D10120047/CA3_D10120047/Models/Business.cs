using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA3_D10120047.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        //virtual - loads up reviews when you try and acces them through business model
        public virtual ICollection<BusinessReview> Reviews { get; set; }
        





    }
}