// IC13, David Lu, CIS 345, T-Th 12pm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWork
{
    public partial class DetailForm : Form
    {
        List<Movie> movieList;

        public DetailForm()
        {
            InitializeComponent();
        }

        // This method should set up to display data in the form.
        public void SetData(List<Movie> movie)
        {
            movieList = movie;
        }

        // The What Button will randomly select one movie from the List of movies. It will display its movie title and rating in the display labels on the form.
        private void whatMovieButton_Click(object sender, EventArgs e)
        {
            Random randomGenerator;
            int index;
            Movie tmpMovie;
            randomGenerator = new Random();
            index = randomGenerator.Next(0,movieList.Count);
            tmpMovie = movieList.ElementAt(index);
            movieDisplayLabel.Text = tmpMovie.Title;
            ratingDisplayLabel.Text = tmpMovie.Rating;
        }
    }
}
