using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductDatabase;

namespace ProductService
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        bool DeleteProduct(int id);

        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product UpdateProduct(Product product);

        [OperationContract]
        int AddProduct(Product product);

        [OperationContract]
        bool DecreaseProductCount(int id, int count);
    }
}
