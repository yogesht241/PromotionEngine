using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepo
{
    public interface IProductService
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }
}
