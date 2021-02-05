namespace Corpus.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;

    public class Food : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [Range(0, 10000)]
        public double CaloriesPerKg { get; set; }

        [Required]
        [Range(0, 1000)]
        public double ProteinPerKg { get; set; }

        [Required]
        [Range(0, 1000)]
        public double CarbsPerKg { get; set; }

        [Required]
        [Range(0, 1000)]
        public double FatsPerKg { get; set; }
    }
}
