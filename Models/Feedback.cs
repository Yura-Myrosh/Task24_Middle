using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Feedback : BaseEntity
    {

        [Required]
        public string AuthorName { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfFeedback { get; set; }
    }
}
