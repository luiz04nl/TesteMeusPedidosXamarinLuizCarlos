using System.Collections.Generic;
using System.Threading.Tasks;
using TesteMeusPedidosLuizCarlos_PCL.Models;

namespace TesteMeusPedidosLuizCarlos_PCL.Services.Interfaces
{
    public interface IProductsService
    {
        Task<List<Product>> FetchProducts();
        
    }
    
}