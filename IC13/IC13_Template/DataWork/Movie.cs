// IC13, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWork
{
    public class Movie
    {
        private string title;
        private string rating;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public Movie(string title, string rating)
        {
            this.Title = title;
            this.Rating = rating;
        }

        public Movie()
        {
            this.Title = "";
            this.Rating = "";
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
