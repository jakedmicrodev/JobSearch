using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "You must enter a company name")]
        public string Name { get; set; }

        [Display(Name = "Website")]
        [Required(ErrorMessage = "You must enter a company web address")]
        public string Website { get; set; }

        [Display(Name = "Is Recruiter")]
        public bool IsRecruiter { get; set; }
    }
}
