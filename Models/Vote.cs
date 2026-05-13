namespace Ankieter.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public int OptionId { get; set; }

        public Option? Option { get; set; }

        public string RespondentId { get; set; } = string.Empty;
    }
}