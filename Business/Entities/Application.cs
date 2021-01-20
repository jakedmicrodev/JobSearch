using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Application
    {
        //private string dateFormat = "{0:MM/dd/yyyy}";
        //private string dateFormat = "{0:yyyy-MM-dd}";


        public int Id { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "You must select a company")]
        public int CompanyId { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        public List<SelectListItem> Companies { get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "You must select a position")]
        public int PositionId { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        public List<SelectListItem> Positions { get; set; }

        [Display(Name = "Position Type")]
        [Required(ErrorMessage = "You must select a position type")]
        public int PositionTypeId { get; set; }

        [Display(Name = "Position Type")]
        public string PositionType { get; set; }

        public List<SelectListItem> PositionTypes { get; set; }

        [Display(Name = "Position Number")]
        [DataType(DataType.MultilineText)]
        public string PositionNumber { get; set; }

        [Display(Name = "Pay Rate")]
        public string PayRate { get; set; }

        [Display(Name = "Requirements")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "You must enter a requirement")]
        public string Requirements { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "You must select a location")]
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        public List<SelectListItem> Locations { get; set; }

        [Display(Name = "Requester")]
        [Required(ErrorMessage = "You must select a requester")]
        public int RequesterId { get; set; }

        [Display(Name = "Requester")]
        public string Requester { get; set; }

        public List<SelectListItem> Requesters { get; set; }

        [Display(Name = "Application Type")]
        [Required(ErrorMessage = "You must select an application type")]
        public int ApplicationTypeId { get; set; }

        [Display(Name = "Application Type")]
        public string ApplicationType { get; set; }

        public List<SelectListItem> ApplicationTypes { get; set; }

        [Display(Name = "Contact")]
        public int ContactId { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }

        public List<SelectListItem> Contacts { get; set; }

        [Display(Name = "Response")]
        public int ResponseTypeId { get; set; }

        [Display(Name = "Response")]
        public string Response { get; set; }

        public List<SelectListItem> Responses { get; set; }

        [Display(Name = "Result")]
        public int ResultId { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }

        public List<SelectListItem> Results { get; set; }

        [Display(Name = "Submit Date")]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "You must enter a submit date")]
        public DateTime SubmitDate { get; set; }

    }
}
