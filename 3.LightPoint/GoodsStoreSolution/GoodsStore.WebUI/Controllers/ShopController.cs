using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoodsStore.Domain.Abstract;
using GoodsStore.Domain.Concrete;

namespace GoodsStore.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IShopRepository shopRepository;
        private IProductRepository productRepository;
        public ShopController(IShopRepository shopRepository, IProductRepository productRepository) //constructor ShopController
        {
            this.shopRepository = shopRepository;//assign repository for this class incom par 
            this.productRepository = productRepository;
        }

        public ViewResult List()
        {           
            return View(shopRepository.Shops);     
           
        }

        [HttpGet]
        public ActionResult ProductsByShop(int id_shop, string nameShop)
        {
            ViewBag.NameShop = nameShop;
            return PartialView(productRepository.GetProductsByShop(id_shop));
        }

    }
}
