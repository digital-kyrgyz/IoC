using System;

namespace IoC
{
    class BL
    {
        private DAL _dal { get; set; }

        public BL()
        {
            _dal = Factory.GetDal();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
