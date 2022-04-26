using Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Book : BaseModel<string>
    {
        public Book()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [StringLength(50, ErrorMessage = "Should have at least 2 symbols", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
