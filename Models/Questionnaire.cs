using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Questionnaire : BaseEntity
    {
        [Required]
        public string QuestText { get; set; }

        [Required]
        public string Answers { get; set; }
    }
}
