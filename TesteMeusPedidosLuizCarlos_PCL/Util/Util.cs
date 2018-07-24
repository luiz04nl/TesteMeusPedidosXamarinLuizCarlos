using System.Collections.Generic;
using System.Linq;
using TesteMeusPedidosLuizCarlos_PCL.Models;

namespace TesteMeusPedidosLuizCarlos_PCL.Util
{
    public static class Util
    {
        public static List<Product> GetProductsByCategoryId(IEnumerable<Product> products, int? categoryId) 
            => products.Where(product => product.Category_id == categoryId).ToList();
    }
}