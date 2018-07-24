using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TesteMeusPedidosLuizCarlos.ViewHolders
{
    public class PromotionViewHolder : RecyclerView.ViewHolder
    {
        public TextView Name { get; set; }
        public RecyclerView ProductsRecyclerView { get; set; }
        
        public PromotionViewHolder (View itemView, Action<int> listener): base (itemView)
        {
            Name = itemView.FindViewById<TextView> (Resource.Id.nameTextView);
            ProductsRecyclerView = itemView.FindViewById<RecyclerView> (Resource.Id.productsRecyclerView);
        }
    }
}