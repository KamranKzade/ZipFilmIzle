using System.Text.Json;
using ZipFilmIzle.Forms;
using ZipFilmIzle.Models;
using ZipFilmIzle.User_Controls;

namespace ZipFilmIzle;

public partial class MainForm : Form
{
    const string _apiKey = "82bcd4c7";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
    private List<string> _movieDataBase;

    public MainForm()
    {
        InitializeComponent();
        _movieDataBase = new();
        if (File.Exists("MovieDataBase.json"))
            _movieDataBase = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("MovieDataBase.json"))!;
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        BackColor = Color.FromArgb(85, 93, 117);

        using HttpClient client = new();
        string jsonStr;

        foreach (var m in _movieDataBase)
        {
            jsonStr = await client.GetStringAsync($"{_url}&t={m}&plot=full");

            if (!jsonStr.Contains("Error"))
            {
                var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
                flowLayoutPanel1.Controls.Add(new UC_Movie(movie!));
            }
        }
    }

    private async void btn_search_Click(object sender, EventArgs e)
    {
        btn_cancel.Visible = true;

        if (string.IsNullOrWhiteSpace(txt_search.Text))
        {
            MessageBox.Show("Please Enter Movie Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Search_Film();
    }

    private async void txt_search_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                MessageBox.Show("Please Enter Movie Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Search_Film();
        }
    }

    private async void Search_Film()
    {
        using HttpClient client = new();
        string jsonStr = await client.GetStringAsync($"{_url}&t={txt_search.Text}&plot=full");

        if (!jsonStr.Contains("Error"))
        {
            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
            MovieInfo movieInfoForm = new(movie);
            movieInfoForm.ShowDialog();

            flowLayoutPanel1.Controls.Add(new UC_Movie(movie!));
            _movieDataBase.Add(movie?.Title!);
            string str = JsonSerializer.Serialize(_movieDataBase);
            File.WriteAllText("MovieDataBase.json", str);
            return;
        }

        MessageBox.Show("Movie Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void btn_cancel_Click(object sender, EventArgs e) => txt_search.Text = string.Empty;

    private void btn_reflesh_Click(object sender, EventArgs e) => flowLayoutPanel1.Controls.Clear();

}
