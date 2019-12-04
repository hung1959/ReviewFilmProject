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
    class ReviewAndRating
    {
        private int _Rating;
        private string _Review;

        public void setRating(int rating)
        {
            this._Rating = rating;
        }
        public int getRating()
        {
            return _Rating;
        }

        public void setReview(string review)
        {
            this._Review = review;
        }
        public string getReview()
        {
            return _Review;
        }
    }
}