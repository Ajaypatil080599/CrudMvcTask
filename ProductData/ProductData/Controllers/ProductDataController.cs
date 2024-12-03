using Microsoft.AspNetCore.Mvc;
using ProductData.Models;
using System.Data.Common;

namespace ProductData.Controllers
{
    public class ProductDataController : Controller
    {
        public IActionResult GetProductDetails(int pg = 1)
        {
            // data from dbcontext  dbdata

            List<ProductDetails> dbdata = new List<ProductDetails>
            {
                      new ProductDetails
                      {
                          ProductId = 1,
                          ProductName = "Patanjali",
                          CategoryId = 1,
                          CategoryName = "HighQuality"
                      }
             };

            new List<ProductDetails>();
            int pageSize = 10;
            int productcount = dbdata.Count(); 
            var pager = new PageIn(productcount, pg, pageSize);
            int pddata = (pg - 1) * pageSize;
            var data = dbdata.Skip(pddata).Take(pager.PageSize).ToList();
            this.ViewBag.PageIn = pager;
            return View(data);
        }
    }
}
