using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using TesteMeusPedidosLuizCarlos.Adapters;
using TesteMeusPedidosLuizCarlos_PCL.Models;
using TesteMeusPedidosLuizCarlos_PCL.Services;

//using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace TesteMeusPedidosLuizCarlos.Activitys
{
    [Activity(Label = "Catalogo", MainLauncher = true, Icon = "@mipmap/icon")]
//    public class CatalogoActivity : AppCompatActivity
    public class CatalogActivity : Activity
    {
        private RecyclerView _mPromotionsRecyclerView;
        private RecyclerView.LayoutManager _mPromotionLayoutManager;
        private PromotionAdapter _mPromotionAdapter;
        private List<Promotion> _mPromotions;
        private List<Product> _mProducts;
        private List<Category> _mCategories;

        private readonly PromotionsService _mPromotionsService;
        private readonly CategoriesService _mCategoriesService;
        private readonly ProductsService _mProductsService;

        public CatalogActivity()
        {
            _mPromotionsService = new PromotionsService();
            _mCategoriesService = new CategoriesService();
            _mProductsService = new ProductsService();
        }

        /// Obter todas as promoções da api
        private async Task<List<Promotion>> FetchPromotions()
            => await _mPromotionsService.FetchPromotions();

        /// Obter todas os produtos da api
        private async Task<List<Product>> FetchProducts()
            => await _mProductsService.FetchProducts();
        
        /// Obter todas as categorias da api
        private async Task<List<Category>> FetchCategories()
            => await _mCategoriesService.FetchCategories();
        
        /// Método executado ao construir a activity
        protected override async void OnCreate(Bundle bundle){
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Catalogo);

            _mPromotions = await FetchPromotions();
            _mProducts = await FetchProducts();
            _mCategories = await FetchCategories();

            AttachUI();
        }
        
        /// Método que cria as opções no menu da toolbar
        public override bool OnCreateOptionsMenu (IMenu menu)
        {
            MenuInflater.Inflate (Resource.Menu.home, menu);
            return base.OnCreateOptionsMenu (menu);
        }
        
        /// Método executado ao presionar alguma opção do menu da toolbar
        public override bool OnOptionsItemSelected (IMenuItem item)
        {	
            Toast.MakeText(this, "Top ActionBar pressed: ", ToastLength.Short).Show();
            return base.OnOptionsItemSelected (item);
        }

        /// Método que anexa os componentes de UI a classe atual
        private void AttachUI()
        {      
//            var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
//            SetSupportActionBar(toolbar);
//            SupportActionBar.Title = "Catalogo";        
            
            _mPromotionsRecyclerView = FindViewById<RecyclerView> (Resource.Id.promotionsRecyclerView);
          
            _mPromotionLayoutManager = new LinearLayoutManager (this);
            _mPromotionsRecyclerView.SetLayoutManager(_mPromotionLayoutManager);

            _mPromotionAdapter = new PromotionAdapter(this, _mPromotions, _mProducts, _mCategories);
//            _mAdapter.ItemClick += OnItemClick;

            _mPromotionsRecyclerView.SetAdapter(_mPromotionAdapter);
        }

//        private void OnItemClick (object sender, int position)
//        {
//        }
    }
    
}