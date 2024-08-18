using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.ViewComponents
{
    public class _FeatureComponentPartial: ViewComponent 

    {
         PortfolyomContext portfolyomContext = new PortfolyomContext();

        public IViewComponentResult Invoke() 
        { 
            var values = portfolyomContext.Features.ToList();
            return View(values); 
        } 
    }
}
