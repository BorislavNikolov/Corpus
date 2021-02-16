namespace Corpus.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;

    public class TotalMacros : BaseDeletableModel<int>
    {
        [Required]
        [Range(0.0d, 25000d)]
        public double Calories { get; set; }

        [Required]
        [Range(0.0d, 500d)]
        public double Proteins { get; set; }

        [Required]
        [Range(0.0d, 5000d)]
        public double Carbs { get; set; }

        [Required]
        [Range(0.0d, 3000d)]
        public double Fats { get; set; }
    }
}
