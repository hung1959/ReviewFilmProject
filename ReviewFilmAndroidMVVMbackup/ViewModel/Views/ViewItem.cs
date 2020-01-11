using Android.App;
using Android.Support.V7.Widget;
using Android.Arch.Lifecycle;
using Android.Support.V4.App;
using FilmProject.Core;
using System.Collections.Generic;
using Android.OS;
using MvvmCross.Converters;
using MvvmCross.Droid.Views;
using static ViewModel.MainActivity;

namespace ViewModel
{
	[Activity(Label = "Films Reviewing Application", MainLauncher = true, Icon = "@mipmap/ic_resource")]
	public partial class ViewItem : FragmentActivity
	{
		ItemViewModel ViewModel;
		RecyclerView RecyclerView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			InitView();
		}

		public void InitView()
		{
			// setup RecyclerView
			RecyclerView = FindViewById<RecyclerView>(Resource.Id.RecyclerView);
			RecyclerView.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
			//Can be GridLayoutManager() instead of LinearLayoutManager


			// setup ViewModel
			ViewModel = ViewModelProviders.Of(this).Get(Java.Lang.Class.FromType(typeof(ItemViewModel))) as ItemViewModel;


		}
		protected override void OnStart()
		{
			base.OnStart();

			// Update Items
			RecyclerView.SetAdapter(new ItemAdapter { ListFilm = ViewModel.GetItems() });
		}


	}
}

