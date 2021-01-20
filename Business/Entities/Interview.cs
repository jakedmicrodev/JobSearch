using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Interview
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "You must select a company")]
        public int CompanyId { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        public List<SelectListItem> Companies { get; set; }

        [Display(Name = "Interview Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "You must enter an interview date")]
        public DateTime InterviewDate { get; set; }

        [Display(Name = "Interview Type")]
        [Required(ErrorMessage = "You must select an interview type")]
        public int InterviewTypeId { get; set; }

        [Display(Name = "Interview Type")]
        public string InterviewType { get; set; }

        public List<SelectListItem> InterviewTypes { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
