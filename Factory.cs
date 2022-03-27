using System;

namespace IoC
{
    class Factory
    {
        public static DAL GetDal()
        {
            return new DAL();
        }
    }
}