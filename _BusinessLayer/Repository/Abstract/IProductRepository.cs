using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DataLayer;

namespace _BusinessLayer.Repository.Abstract
{
    public interface IProductRepository
    {
        List<SP_ProductReport1_Result> Report1Result();
    }
}
