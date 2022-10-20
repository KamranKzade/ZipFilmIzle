using System.Text.Json;
using ZipFilmIzle.Models;

namespace ZipFilmIzle.Forms;

public partial class SignIn : Form
{
    User user = new();
    List<User> _UserDataBase = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("UserDataBase.json"))!;
    public SignIn()
    {
        InitializeComponent();
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
        user.Username = txt_username.Text;
        user.Password = txt_password.Text;
        foreach (var userData in _UserDataBase)
        {
            if (userData.Username == user.Username && userData.Password == user.Password)
            {
                MessageBox.Show($"Welcome {userData.Name}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                return;
            }
                
        }
        MessageBox.Show($"Bele Istifadeci tapilmadi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}
