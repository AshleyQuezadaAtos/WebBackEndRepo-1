using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebCourseRepo.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Status : Entity
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

 
        [StringLength(200)]
        public string? Description { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
