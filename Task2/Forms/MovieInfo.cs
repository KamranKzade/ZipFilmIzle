using ZipFilmIzle.Models;

namespace ZipFilmIzle.Forms
{
    public partial class MovieInfo : Form
    {
        public MovieInfo(Movie movie)
        {
            InitializeComponent();
            pictureBox1.Load(movie.Poster);
            lbl_film_name.Text += movie.Title;
            lbl_writer.Text += movie.Writer;
            lbl_country.Text += movie.Country;
            lbl_actors.Text += movie.Actors;
            lbl_type.Text += movie.Type;
            lbl_time.Text += movie.Runtime;
            lbl_languages.Text += movie.Language;
            lbl_imdb.Text += movie.ImdbRating;
            txt_description.Text = movie.Plot;
        }
    }
}
