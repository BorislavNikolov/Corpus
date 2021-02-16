namespace Corpus.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;
    using Corpus.Data.Models.Enums;

    public class Еxercise : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public TargetMuscleGroup TargetMuscleGroup { get; set; }
    }
}
