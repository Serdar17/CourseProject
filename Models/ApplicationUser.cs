using Microsoft.AspNetCore.Identity;

namespace CourseProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public DateTime LastLoginDateTime { get; set; }

    }
}
