namespace Corpus.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;
    using Corpus.Data.Models.Enums;

    public class Workout : BaseDeletableModel<int>
    {
        public Workout()
        {
            this.Exercises = new HashSet<Еxercise>();
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public DifficultLevel DifficultLevel { get; set; }

        [Required]
        public virtual ICollection<Еxercise> Exercises { get; set; }
    }
}
