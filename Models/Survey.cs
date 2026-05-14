using Microsoft.CodeAnalysis.Options;
using System.ComponentModel.DataAnnotations;

namespace Ankieter.Models
{
    public class Survey
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tytuł")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Opis")]
        public string Description { get; set; } = string.Empty;

        public string CreatorId { get; set; } = string.Empty;

        public List<Option> Options { get; set; } = new();
    }
}