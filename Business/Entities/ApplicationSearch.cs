using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Business.Entities
{
    public class ApplicationSearch
    {

        [Display(Name = "Company")]
        [Required(ErrorMessage = "You must select a company")]
        public int CompanyId { get; set; }
        public List<SelectListItem> Companies { get; set; }

        [Display(Name = "Position Number")]
        [DataType(DataType.MultilineText)]
        public string PositionNumber { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Requester")]
        [Required(ErrorMessage = "You must select a requester")]
        public int RequesterId { get; set; }
        public List<SelectListItem> Requesters { get; set; }

        [Display(Name = "Contact")]
        public int ContactId { get; set; }
        public List<SelectListItem> Contacts { get; set; }

    }
}
