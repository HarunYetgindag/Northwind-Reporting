using _BusinessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;

namespace _BusinessLayer.Repository.Concrete
{
    public class ProductConcrete : IProductRepository
    {
        public List<SP_ProductReport1_Result> Report1Result()
        {
            using (NorthwindEntities db=new NorthwindEntities ())
            {
                return db.SP_ProductReport1().ToList();
            }
        }
    }
}
