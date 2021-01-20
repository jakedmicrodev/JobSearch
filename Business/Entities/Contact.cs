using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Contact
    {
        //private string phone;

        public int Id { get; set; }

        [Display(Name = "Contact Name")]
        [Required(ErrorMessage = "You must enter a contact name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must select a company")]
        public int CompanyId { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }

        public List<SelectListItem> Companies { get; set; }

        [Required(ErrorMessage = "You must select a contact type")]
        public int ContactTypeId { get; set; }

        [Display(Name = "Contact Type")]
        public string ContactType { get; set; }

        public List<SelectListItem> ContactTypes { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
        //public string Phone
        //{
        //    get { return phone is null ? "" : phone; }
        //    set { phone = value; }
        //}

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
