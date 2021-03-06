using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Books = new HashSet<Book>();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Password should be between 3 and 50 characters!", MinimumLength = 3)]
        public string Password { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
