using System.Text.Json;
using ZipFilmIzle.Models;
using ZipFilmIzle.User_Controls;

namespace ZipFilmIzle;

public partial class Form1 : Form
{
    const string _apiKey = "82bcd4c7";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
    private List <string> _movieDataBase;

    public Form1()
    {
        InitializeComponent();
        _movieDataBase = new();
       // if (File.Exists("MovieDataBase.json"))
       //     _movieDataBase = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("MovieDataBase.json"))!;
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
}