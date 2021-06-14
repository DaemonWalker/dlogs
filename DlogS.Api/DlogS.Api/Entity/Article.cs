using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;

namespace DlogS.Api.Entity
{
    public class Article
    {
        [Column(IsIdentity = true)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ShowId { get; set; }
        public string Summary { get; set; }
        public DateTime UploadTime { get; set; }
    }
}
