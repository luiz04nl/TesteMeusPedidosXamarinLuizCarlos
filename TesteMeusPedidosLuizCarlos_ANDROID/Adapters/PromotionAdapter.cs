using System.Collections.Generic;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using TesteMeusPedidosLuizCarlos.ViewHolders;
using TesteMeusPedidosLuizCarlos_PCL.Models;
using TesteMeusPedidosLuizCarlos_PCL.Util;

namespace TesteMeusPedidosLuizCarlos.Adapters
{
    public class PromotionAdapter : RecyclerView.Adapter
    {
//        public event EventHandler<int> ItemClick;
        private readonly Context _mContext;
        private readonly List<Promotion> _mPromotions;
        private readonly List<Product> _mProducts;
        private readonly List<Category> _mCategories;

        public PromotionAdapter (Context context,
            List<Promotion> promotions, 
            List<Product> products,
            List<Category> categories)
        {
            _mContext = context;
            _mPromotions = promotions;
            _mProducts = products;
            _mCategories = categories;
        }

        public override RecyclerView.ViewHolder 
            OnCreateViewHolder (ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From (parent.Context).
                Inflate(Resource.Layout.PromotionItemView, parent, false);            
                
            var vh = new PromotionViewHolder(itemView, OnClick); 
            return vh;
        }
        
        public override void 
            OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
        {
            if (holder is PromotionViewHolder vh)
            {
                vh.Name.Text = _mPromotions[position].Name;

                var products = Util.GetProductsByCategoryId(_mProducts, _mPromotions[position].Category_id);

                var productsAdapter = new ProductAdapter(products);
                var productsLayoutManager = new LinearLayoutManager(_mContext);
                
                vh.ProductsRecyclerView.SetLayoutManager(productsLayoutManager);
                vh.ProductsRecyclerView.SetAdapter(productsAdapter);
            
//            itemView.Click += (sender, e) => listener (LayoutPosition);
            }
        }

        public override int ItemCount => _mPromotions.Count;

        private void OnClick (int position)
        {
//            ItemClick?.Invoke(this, position);
        }
    }
}