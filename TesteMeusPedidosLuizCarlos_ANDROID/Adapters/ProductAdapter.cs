using System.Collections.Generic;
using Android.Net;
using Android.Support.V7.Widget;
using Android.Views;
using TesteMeusPedidosLuizCarlos.ViewHolders;
using TesteMeusPedidosLuizCarlos_PCL.Models;

namespace TesteMeusPedidosLuizCarlos.Adapters
{
    public class ProductAdapter : RecyclerView.Adapter
    {
        private readonly List<Product> _mProducts;

        public ProductAdapter (List<Product> products)
        {
            _mProducts = products;
        }

        public override RecyclerView.ViewHolder 
            OnCreateViewHolder (ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From (parent.Context).
                Inflate(Resource.Layout.ProductsItemView, parent, false);
            var vh = new ProductViewHolder(itemView, OnClick); 
            return vh;
        }
        
        public override void 
            OnBindViewHolder (RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ProductViewHolder vh)
            {
                vh.Name.Text = _mProducts[position].Name;                
                vh.Photo.SetImageURI(Uri.Parse(_mProducts[position].Photo));

                
            }
        }

        public override int ItemCount => _mProducts.Count;

        private void OnClick (int position)
        {
//            ItemClick?.Invoke(this, position);
        }
    }
    
}