using System;
using System.Collections.Generic;

namespace ViewModel
{
	public class Films
	{
		public string Name { get; set; }
		public int Image { get; set; }


		public List<Films> ListFilm;

		public Films(string name, int image)
		{
			Name = name;
			Image = image;
		}
		public Films(string name)
		{
			Name = name;
		}
		public Films()
		{
			ListFilm = new List<Films>();
		}

		public void AddFilms(string name, int image)
		{
			ListFilm.Add(new Films(name, image));
		}
		public void AddFilms(string name)
		{
			ListFilm.Add(new Films(name));
		}

		public void setName(string name)
		{
			Name = name;
		}

		public void setImage(int image)
		{
			Image = image;
		}

	}
}
