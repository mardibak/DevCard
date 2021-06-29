using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"AspCource","Asp .NetCore For Beginer","blog-post-thumb-3.jpg"),
                new Article(2,"C# Professional","C# For Advanced Programmer", "blog-post-thumb-6.jpg"),
                new Article(4,"Hmtl5","Learning Html5 and BootStrop","blog-post-thumb-1.jpg"),
                new Article(3,"JS", "JavaScript Cource For Advanced Programmer","blog-post-thumb-4.jpg")
            };

            return View("LatestArticles", articles);
        }
    }
}
