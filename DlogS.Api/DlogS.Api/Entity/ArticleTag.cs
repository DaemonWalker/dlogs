using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;

namespace DlogS.Api.Entity
{
    public class ArticleTag
    {
        [Column(IsIdentity = true)]
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TagId { get; set; }
    }
}
