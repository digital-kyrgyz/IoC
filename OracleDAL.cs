using System;

namespace IoC
{
    class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            //Sql Server
            return new List<Product>()
             {
                 new Product{Id = 1, Name = "Pencil 1, Oracle", Price = 100, Stock = 200 },
                 new Product{Id = 2, Name = "Pencil 2, Oracle", Price = 100, Stock = 200 },
                 new Product{Id = 3, Name = "Pencil 3, Oracle", Price = 100, Stock = 200 },
                 new Product{Id = 4, Name = "Pencil 4, Oracle", Price = 100, Stock = 200 },
            };
        }
    }
}