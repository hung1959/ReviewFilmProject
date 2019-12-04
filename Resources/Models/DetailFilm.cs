using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ReviewFilmProjectWithLogin.Resources.Models
{
    class DetailFilm
    {
        private string _Description;
        private string _KindOfFilm;
        private string _Author;
        private string _PosterURL;
        public void setKindOfFilm(string kindoffilm)
        {
            this._KindOfFilm = kindoffilm;
        }
        public string getKindOfFilm()
        {
            return _KindOfFilm;
        }
        public void setAuthor(string author)
        {
            this._Author = author;
        }
        public string getAuthor()
        {
            return _Author;
        }
        public void setDescription(string description)
        {
            this._Description = description;
        }
        public string getDescription()
        {
            return _Description;
        }
        public void setPosterURL(string PosterURL)
        {
            this._PosterURL = PosterURL;
        }
        public string getPosterURL()
        {
            return _PosterURL;
        }
    }
}