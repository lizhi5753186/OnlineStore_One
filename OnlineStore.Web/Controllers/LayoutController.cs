using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Web.ProductService;

namespace OnlineStore.Web.Controllers
{
    public class LayoutController : Controller
    {
        #region Shared Layout Partial view Actions

        public ActionResult _LoginPartial()
        {
            return PartialView();
        }

        public ActionResult CategoriesPartial()
        {
            using (var proxy = new ProductServiceClient())
            {
                var categories = proxy.GetCategories();
                return PartialView(categories);
            }
        }

        public ActionResult NewProductsPartial()
        {
            using (var proxy = new ProductServiceClient())
            {
                var newProducts = proxy.GetNewProducts(4);
                return PartialView(newProducts);
            }
        }

        public ActionResult ProductsPartial()
        {
            using (var proxy = new ProductServiceClient())
            {
                var allProducts = proxy.GetProducts();
                return PartialView(allProducts);
            }
        }
        #endregion 

    }
}
