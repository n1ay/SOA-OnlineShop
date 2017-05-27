using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductDatabase;

namespace ProductService
{
    public class ProductService : IProductService
    {
        ProductRepository db = new ProductRepository();
        Logger logger = new Logger();

        public bool DeleteProduct(int id)
        {
            logger.Write("Delete id=" + id, LogLevel.INFO);
            return db.Delete(id);
        }

        public Product GetProduct(int id)
        {
            logger.Write("Get id=" + id, LogLevel.INFO);
            return db.Get(id);
        }

        public List<Product> GetAllProducts()
        {
            logger.Write("Get all", LogLevel.INFO);
            return db.GetAll();
        }

        public Product UpdateProduct(Product product)
        {
            logger.Write("Update id=" + product.Id, LogLevel.INFO);
            return db.Update(product);
        }

        public int AddProduct(Product product)
        {
            logger.Write("Add id=" + product.Id, LogLevel.INFO);
            return db.Add(product);
        }

        public bool DecreaseProductCount(int id, int decreaseCount)
        {
            logger.Write("Decrease id=" + id + " decrease count=" + decreaseCount, LogLevel.INFO);
            Product product = db.Get(id);
            if (product != null)
            {
                product.Count -= decreaseCount;
                if (product.Count >= 0)
                {
                    db.Update(product);
                    return true;
                }
            }
            return false;
        }
        
    }
}
