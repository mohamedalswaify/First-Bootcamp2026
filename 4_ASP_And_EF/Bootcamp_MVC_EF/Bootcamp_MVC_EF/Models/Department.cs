using System.ComponentModel.DataAnnotations;

namespace Bootcamp_MVC_EF.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
