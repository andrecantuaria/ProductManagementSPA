using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PMDAL
{
    public class ProductRepository
    {

        public List<Product> GetProductRepo()
        {
            ProductManagementSPAEntities pme = new ProductManagementSPAEntities();
            return pme.Products.ToList();
        }


        public bool AddProductRepo(Product product)
        {
            ProductManagementSPAEntities pme = new ProductManagementSPAEntities();
            if (product != null)
            {
                pme.Products.Add(product);
                pme.SaveChanges();
                return true;
            }
            return false;

        }

        public bool DeleteProductRepo(int productId)
        {
            ProductManagementSPAEntities pme = new ProductManagementSPAEntities();
            var product = pme.Products.Where(x => x.ProductId == productId).FirstOrDefault();
            //var product = pme.Products.FirstOrDefault(x => x.ProductId == productId);

            if (product != null)
            {
                pme.Products.Remove(product);
                pme.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProductRepo(Product product)
        {
            ProductManagementSPAEntities pme = new ProductManagementSPAEntities();
            Product productToBeUpdated = pme.Products.FirstOrDefault(x => x.ProductId == product.ProductId);

            if(productToBeUpdated != null)
            {
                Mapper.Map(product, productToBeUpdated);
                pme.SaveChanges();
                return true;
            }
            return false;
        }

        public Product GetProductByIdRepo(int id)
        {
            ProductManagementSPAEntities pme = new ProductManagementSPAEntities();
            return pme.Products.FirstOrDefault(x => x.ProductId == id);
        }




    }
}
