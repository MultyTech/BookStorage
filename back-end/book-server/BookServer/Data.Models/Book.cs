using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Book : BaseModel<string>
    {
        public Book()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }

        [Required]
        [StringLength(50, ErrorMessage = "Should have between 2 and 50 symbols", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]

        [StringLength(40, ErrorMessage = "Should have between 2 and 40 symbols", MinimumLength = 2)]
        public string Author { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be positive number")]
        public decimal Price { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
