using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TesteMeusPedidosLuizCarlos.ViewHolders
{
    public class ProductViewHolder : RecyclerView.ViewHolder
    {
        public TextView Name { get; set; }
        public ImageView Photo { get; set; }

        public ProductViewHolder (View itemView, Action<int> listener): base (itemView)
        {
            Name = itemView.FindViewById<TextView> (Resource.Id.nameTextView);
            Photo = itemView.FindViewById<ImageView> (Resource.Id.photoImageView);
        }
    }
}