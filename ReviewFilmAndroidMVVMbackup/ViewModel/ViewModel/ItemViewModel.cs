using System.Collections.Generic;
using ViewModel;
//using Xamarin.Forms.PlatformConfiguration;

namespace FilmProject.Core
{
	public class MainViewModel : MvvmCross.ViewModels.MvxViewModel
	{
		private double _Name;
		public double Name
		{
			get => _Name;
			set
			{
				_Name = value;
				RaisePropertyChanged(() => Name);
			}
		}

		private double _Image;
		public double Image
		{
			get => _Image;
			set
			{
				_Image = value;
				RaisePropertyChanged(() => Image);
			}
		}
	}

	public class ItemViewModel : Android.Arch.Lifecycle.ViewModel
	{
		List<Films> Items;

		public List<Films> GetItems()
		{
			if (Items == null)
				Items = LoadItems();
			return Items;
		}

		List<Films> LoadItems()
		{
			List<string> ListFilm = new List<string>();
			ListFilm.Add("Fast and Furius 1");
			ListFilm.Add("Fast and Furius 2");
			ListFilm.Add("Fast and Furius 3");
			ListFilm.Add("Fast and Furius 4");
			ListFilm.Add("Fast and Furius 5");
			ListFilm.Add("Fast and Furius 6");

			List<int> ListImgFilm = new List<int>();
			ListImgFilm.Add(Resource.Mipmap.ic_resource);
			ListImgFilm.Add(Resource.Mipmap.ic_resource);
			ListImgFilm.Add(Resource.Mipmap.ic_resource);
			ListImgFilm.Add(Resource.Mipmap.ic_resource);
			ListImgFilm.Add(Resource.Mipmap.ic_resource);
			ListImgFilm.Add(Resource.Mipmap.ic_resource);

			//Items = new List<Films>();
			//for (var i = 0; i < Items.Count; i++)
			//{

			//	Items.Add(ListFilm);
			//}
			//return Items;

			Items = new List<Films>();
			for (var i = 0; i < ListFilm.Count; i++)
			{
				Items.Add(new Films { Name = ListFilm[i] ,
									  Image = ListImgFilm[i]});
			}
			return Items;

		}

	}
}
