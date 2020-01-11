using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using Android.Widget;

namespace ViewModel
{
	public partial class MainActivity
	{
		internal class ItemAdapter : RecyclerView.Adapter
		{
			public List<Films> ListFilm { get; set; }

			public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
			{
				var view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ViewItem, parent, false);
				return new ItemViewHolder(view);
			}

			public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
			{
				var itemViewHolder = holder as ItemViewHolder;
				itemViewHolder.txtName.Text = ListFilm[position].Name;

				itemViewHolder.imgFilm.SetImageResource(ListFilm[position].Image);
			}

			public override int ItemCount => ListFilm.Count;

			class ItemViewHolder : RecyclerView.ViewHolder
			{
				public TextView txtName { get; set; }
				public ImageView imgFilm;
				
				public ItemViewHolder(View itemView) : base(itemView)
				{
					txtName = itemView.FindViewById<TextView>(Resource.Id.txtName);
					imgFilm = itemView.FindViewById<ImageView>(Resource.Id.imgFilm);

				}
			}
		}
	}
}

