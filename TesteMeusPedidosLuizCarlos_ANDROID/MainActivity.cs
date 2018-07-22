using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using TesteMeusPedidosLuizCarlos_PCL.Models;
using TesteMeusPedidosLuizCarlos_PCL.Services;

namespace TesteMeusPedidosLuizCarlos
{
    [Activity(Label = "TesteMeusPedidosLuizCarlos", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        private readonly PromotionsService _promotionsService;

        public MainActivity()
        {
            _promotionsService = new PromotionsService();
        }

        /// Método executado ao construir a activity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            var protectedromotions = FetchPromotions();

        }
        
        /// Obter todas as promoções da api
        private async Task<List<Promotion>> FetchPromotions()
        {
            var promotions =  await _promotionsService.FetchPromotions();            
            return promotions;
        }
        
    }
}