using PMDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PMBLL
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            ProductRepository pr = new ProductRepository();
            return pr.GetProductRepo();
        }

        
        public Product GetProduct(int id)
        {
            ProductRepository pr = new ProductRepository();
            return pr.GetProductByIdRepo(id);
        }
        

        public bool DeleteProduct(int productId)
        {
            ProductRepository pr = new ProductRepository();
            return pr.DeleteProductRepo(productId);
        }
        
        public bool AddProduct(Product product)
        {
            ProductRepository pr = new ProductRepository();
            return pr.AddProductRepo(product);
            
        }
        
        public bool UpdateProduct(Product product)
        {
            ProductRepository pr = new ProductRepository();
            return pr.UpdateProductRepo(product);
        }
        




    }
}
