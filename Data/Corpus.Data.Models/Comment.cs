namespace Corpus.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Corpus.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }

        [MaxLength(200)]
        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
