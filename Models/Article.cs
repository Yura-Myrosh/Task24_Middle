using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Article : BaseEntity
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfPublish { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
