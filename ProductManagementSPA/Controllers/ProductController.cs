using PMBLL;
using PMDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagementSPA.Models; // access vm
using AutoMapper; 

namespace ProductManagementSPA.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            ProductService  productService = new ProductService();
            var products = productService.GetProducts();

            List<ProductVM> productVMs = new List<ProductVM>();

            productVMs = Mapper.Map<List<Product>, List<ProductVM>>(products);
            return Json(productVMs, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetProductById(int id)
        {
            ProductService productService = new ProductService();
            var product = productService.GetProduct(id);
            return Json(product, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            ProductService productService = new ProductService();
            var productAdded = productService.AddProduct(product);
            return Json(productAdded, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateProduct(Product product)
        {
            ProductService productService = new ProductService();
            var productUpdated = productService.UpdateProduct(product);
            return Json(productUpdated, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            ProductService productService = new ProductService();
            if (productService.DeleteProduct(id))
            {
                return Json(JsonRequestBehavior.AllowGet);
            }
            return null;
        }

    }
}