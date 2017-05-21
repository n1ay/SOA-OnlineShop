using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace ProductDatabase
{
    public class ProductRepository : IProductRepository
    {
        public int Add(Product product)
        {
            using (var connection = new NpgsqlConnection(Config.ConnectionString))
            {
                connection.Open();
                int rowsAffected = connection.Execute("INSERT INTO public.\"Products\" VALUES (@ID, @Name, @Count, @Price)", new { product.Id, product.Name, product.Count, product.Price });
                if (rowsAffected > 0)
                    return product.Id;
                else
                    return -1;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new NpgsqlConnection(Config.ConnectionString))
            {
                connection.Open();
                int rowsAffected = connection.Execute("DELETE FROM public.\"Products\" WHERE \"Id\"=@ID", new { id });
                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
        }

        public Product Get(int id)
        {
            using (var connection = new NpgsqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var collection = connection.Query<Product>("SELECT * FROM public.\"Products\" WHERE \"Id\"=@ID", new { id });
                if (collection.Count() > 0)
                    return collection.ElementAt(0);
                else
                    return null;
            }
        }

        public List<Product> GetAll()
        {
            using (var connection = new NpgsqlConnection(Config.ConnectionString))
            {
                connection.Open();
                var collection = connection.Query<Product>("SELECT * FROM public.\"Products\"");
                if (collection.Count() > 0)
                    return collection.AsList();
                else
                    return null;
            }
        }

        public Product Update(Product product)
        {
            using (var connection = new NpgsqlConnection(Config.ConnectionString))
            {
                connection.Open();
                int rowsAffected = connection.Execute("UPDATE public.\"Products\" SET \"Name\"=@Name, \"Count\"=@Count, \"Price\"=@Price WHERE \"Id\"=@ID", new { product.Name, product.Count, product.Price, product.Id, });
                if (rowsAffected > 0)
                    return product;
                else
                    return null;
            }
        }
    }
}
