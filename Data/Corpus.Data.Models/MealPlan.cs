namespace Corpus.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;

    public class MealPlan : BaseDeletableModel<int>
    {
        public MealPlan()
        {
            this.Meals = new HashSet<Food>();
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public virtual ICollection<Food> Meals { get; set; }
    }
}
