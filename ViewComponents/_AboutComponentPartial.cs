using Microsoft.AspNetCore.Mvc;
using süleyman.DAL.Context;
// bu sayfada birden fazla alandan veri alcağimiz için vievbag yapcaz 

namespace süleyman.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
          
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();

            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();


            return View();
        }
    }
}
