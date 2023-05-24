using System.ComponentModel.DataAnnotations;

namespace NumbersInEnglish.Models
{
    public class Numbers
    {
        [Key]
        public int IdNumber { get; set; }

        public int Number { get; set; }
        public string Traduction { get; set; } = string.Empty;
    }
}