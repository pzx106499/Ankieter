using System.ComponentModel.DataAnnotations;

namespace Ankieter.Models
{
    public class Option
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Treść opcji")]
        public string Text { get; set; } = string.Empty;

        public int SurveyId { get; set; }

        public Survey? Survey { get; set; }

        public List<Vote> Votes { get; set; } = new();
    }
}