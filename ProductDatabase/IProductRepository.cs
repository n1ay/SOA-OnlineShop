using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDatabase
{
    public interface IProductRepository
    {
        int Add(Product product);
        Product Update(Product product);
        bool Delete(int id);
        Product Get(int id);
        List<Product> GetAll();
    }
}
