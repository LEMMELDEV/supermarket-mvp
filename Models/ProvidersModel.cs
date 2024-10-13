using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProvidersModel
    {

        [DisplayName("Providers Id")]
        public int Id { get; set; }

        [DisplayName("Providers Document Number")]
        [Required(ErrorMessage = "Provider document is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provider document must be between 3 and 50 characters")]
        public string Document_Number { get; set; }

        [DisplayName("Firts Name")]
        [Required(ErrorMessage = "Firts Name is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Firts Name must be between 3 and 200 characters")]
        public string First_Name { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 200 characters")]
        public string Last_Name { get; set; }


        public string Address { get; set; }
        public string Birthday { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }


    }
}
