using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Text, ErrorMessage = "Please enter a valid date.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [StringLength(30)]
        [Required]
        [RegularExpression(@"[A-Z]+[a-zA-Z""'\s-]*$",ErrorMessage = "Genre must start with a capital letter and only contain letters, single qutoes and dashes")]
        public string Genre { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        [DataType(DataType.Currency)]
        [Range(0.99,100, ErrorMessage = "Please enter a valid price between $0.99 and $100")]
        [Required(ErrorMessage = "Please enter a valid price")]
        public decimal? Price { get; set; }

        [StringLength(5)]
        [Required]
        [RegularExpression(@"[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Genre must start with a capital letter and only contain letters, single qutoes and dashes")]
        public string Rating { get; set; }

    }
}
