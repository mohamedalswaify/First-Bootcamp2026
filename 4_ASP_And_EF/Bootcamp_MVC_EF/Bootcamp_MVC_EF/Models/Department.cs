using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bootcamp_MVC_EF.Models
{
    [Index(nameof(Uuid), IsUnique = true)]

    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Uuid { get; set; }  = Guid.NewGuid().ToString();

        [DisplayName("My Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
