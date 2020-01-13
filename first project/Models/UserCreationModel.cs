using FirstProjectDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project.Models
{
    public class UserCreationModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "* A Field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "* Field must contain from 2 to 50 characters.")]
        public string Name { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "* A Field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "* Field must contain from 2 to 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* A Field is required.")]
        [EmailAddress(ErrorMessage = "* An Email must be valid.")]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "* A Field is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* A Field is required.")]
        [Range(1, 120)]
        public int Age { get; set; }
        public int SexId { get; set; }
        public int Id { get; set; }
        [Display(Name = "Sex")]
        public List<SexTypeModel> SexTypes { get; set; }
        public string SexType(int SexId)
        {
            return SexTypes.FirstOrDefault(x => x.Id == SexId).SexType;
        }
    }
}
