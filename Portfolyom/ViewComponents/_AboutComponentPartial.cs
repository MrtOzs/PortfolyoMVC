using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolyomContext portfolyomContext = new PortfolyomContext();  
        public IViewComponentResult Invoke() 
        { 
            ViewBag.aboutTitle = portfolyomContext.Abouts.Select (a => a.Title).FirstOrDefault();   
            ViewBag.aboutSubDecription = portfolyomContext.Abouts.Select (a => a.SubDescription).FirstOrDefault();   
            ViewBag.aboutDetail = portfolyomContext.Abouts.Select (a => a.Detail).FirstOrDefault();   
            return View(); 
        } 
    }
}
