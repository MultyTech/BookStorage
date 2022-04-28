using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Data.Models
{
    public class ApplicationRole: IdentityRole
    {
        public ApplicationRole()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Users = new HashSet<ApplicationUser>();
        }

        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Password should be between 3 and 50 characters!", MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
