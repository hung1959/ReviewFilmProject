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
    class FilmInfor
    {
        private string _FilmName;
        private DetailFilm _DetailFilm;
        private ReviewAndRating _ReviewAndRating;

        public FilmInfor()
        {

        }
        public FilmInfor(string filmname, DetailFilm detailfirm)
        {
            _FilmName = filmname;
            _DetailFilm = detailfirm;

        }
        public void setFilmName(string filmname)
        {
            this._FilmName = filmname;
        }
        public string getFilmName()
        {
            return _FilmName;
        }
        public void setDetailFilm(DetailFilm detailfirm)
        {
            this._DetailFilm = detailfirm;
        }
        public DetailFilm getDetailFilm()
        {
            return _DetailFilm;
        }
    }
}