using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {
                new Project(1,"اینتل","تولید کننده قطعات سخت","project-1.jpg","Intel"),
                new Project(2,"آمازون","درخواست خرید آنلاین","project-2.jpg","Amazon"),
                new Project(3,"گوگل","سیستم جستجوگر","project-3.jpg","GoodGe"),
                new Project(4,"ناسا","کهکشان پیما ناسا","project-4.jpg","NASA")
            };
            return View("_Projects",projects);
        }
    }
}
