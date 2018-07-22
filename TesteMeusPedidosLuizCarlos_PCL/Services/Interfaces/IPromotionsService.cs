using System.Collections.Generic;
using System.Threading.Tasks;
using TesteMeusPedidosLuizCarlos_PCL.Models;

namespace TesteMeusPedidosLuizCarlos_PCL.Services.Interfaces
{
    public interface IPromotionsService
    {
        Task<List<Promotion>> FetchPromotions();

//        Task PostPromotion(Promotion promotion);

//        Task DeletePromotion(string id);
        
    }
    
}