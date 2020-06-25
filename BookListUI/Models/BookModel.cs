using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListUI.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3,ErrorMessage = "A book title should be at least 3 charaters.")]
        public string Title { get; set; }

        [Required]
        public CategoryModel Category { get; set; }

        [Range(0, 1000, ErrorMessage = "That book cost to much")]
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
