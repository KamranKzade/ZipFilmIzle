using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZipFilmIzle.Models;

namespace ZipFilmIzle.User_Controls;

public partial class UC_Movie : UserControl
{
    public Movie Movie { get; set; }

    public UC_Movie(Movie movie)
    {
        InitializeComponent();

        Movie = movie;

        pictureBox1.Load(movie.Poster);
        lbl_movie_name.Text = movie.Title;
        lbl_year.Text = $"YEAR: {movie.Year}";
        lbl_imdb.Text = $"IMDB: {movie?.Ratings?[0]?.Value!.ToString() }";

    }
}