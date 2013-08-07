using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//after you add validations you need to re - migrate DB
//validations are run on server and client side

namespace CA3_D10120047.Models
{
    public class BusinessReview
    {
        public int Id { get; set; }

        [Required]//ints are required by default
        //[Range(1, 10, ErrorMessage = "rating must be a banana between 1 and 10")]
        public int Rating { get; set; }

        [Required]
        [StringLength (1024)]
        public string Body { get; set; }

        [Display(Name="User Name")]
        [DisplayFormat(NullDisplayText="anonomous")]
        public string ReviewerName { get; set; }
        
        public int BusinessId { get; set; }

        



        
    }
}