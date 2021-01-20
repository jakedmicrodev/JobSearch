using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Response
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "You must select a contact type")]
        public int ResponseTypeId { get; set; }

        [Display(Name = "Response Type")]
        public string ResponseType { get; set; }

        public List<SelectListItem> ResponseTypes { get; set; }

        [Display(Name = "Response Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "You must enter a response date")]
        public DateTime ResponseDate { get; set; }

        [Display(Name = "ResultId")]
        [Required(ErrorMessage = "You must select a result")]
        public int ResultId { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }

        public List<SelectListItem> Results { get; set; }

        [Display(Name = "Contact")]
        public int ContactId { get; set; }

        [Display(Name = "Contact")]
        public string Contact { get; set; }

        public List<SelectListItem> Contacts { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}
