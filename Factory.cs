using System;

namespace IoC
{
    class Factory
    {
        public static IDAL GetDal()
        {
            return new DAL();
        }
    }
}