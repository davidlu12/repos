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

    public partial class MoviesForm : Form
    {
        BindingList<Movie> movieList;
        DetailForm detailsForm;


        public MoviesForm()
        {
            InitializeComponent();
        }

        // The Load event handler will instantiate the BindingList and set it as the DataSource of the ListBox
        private void MoviesForm_Load(object sender, EventArgs e)
        {
            movieList = new BindingList<Movie>();
            moviesListBox.DataSource = movieList;
        }

        // The Load Sample Data button will add some sample movies to the BindingList
        private void loadButton_Click(object sender, EventArgs e)
        {
            Movie tmpMovie;

            tmpMovie = new Movie("Movie1","R");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie2", "PG");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie3", "R");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie4", "PG");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie5", "PG-13");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie6", "PG-13");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie7", "R");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie8", "PG");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie9", "R");
            movieList.Add(tmpMovie);
            tmpMovie = new Movie("Movie10", "PG");
            movieList.Add(tmpMovie);
        }

        // The Open Details button will open the DetailsForm and pass to it a list of movies, which have been selected by the user
        private void movieDetailsButtons_Click(object sender, EventArgs e)
        {
            List<Movie> selectedMovies = new List<Movie>();
            foreach (Movie m in moviesListBox.SelectedItems)
            {
                selectedMovies.Add(m);
            }
            detailsForm = new DetailForm();
            detailsForm.SetData(selectedMovies);
            detailsForm.Show();
        }
    }
}
