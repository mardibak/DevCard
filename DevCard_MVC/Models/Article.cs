using System;

namespace DevCard_MVC.Models
{
    public class Article
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
