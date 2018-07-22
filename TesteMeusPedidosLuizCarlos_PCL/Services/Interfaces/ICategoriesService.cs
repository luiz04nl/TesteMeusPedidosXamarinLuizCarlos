using System.Collections.Generic;
using System.Threading.Tasks;
using TesteMeusPedidosLuizCarlos_PCL.Models;

namespace TesteMeusPedidosLuizCarlos_PCL.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<List<Category>> FetchCategories();
        
    }
    
}