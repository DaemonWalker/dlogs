using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DlogS.Api.Entity;

namespace DlogS.Api.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ShowId { get; set; }
        public string Summary { get; set; }
        public string UploadTime { get; set; }

        public static implicit operator ArticleModel(Article entity) =>
            new ArticleModel
            {
                Content = entity.Content,
                ShowId = entity.ShowId,
                Summary = entity.Summary,
                Title = entity.Title,
                UploadTime = entity.UploadTime.ToString("yyyy/MM/dd HH:mm:ss")
            };


    }
}
