
using ZipFilmIzle.Models;

namespace ZipFilmIzle.Forms;

public partial class SignUpForm : Form
{
   
    User user = new();

    public SignUpForm()
    {
        InitializeComponent();
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
        user.Name = txt_name.Text;
        user.Surname = txt_surname.Text;

        try
        {
            byte.TryParse(txt_age.Text, out byte age);
            user.Age = age;
        }
        catch
        {
            MessageBox.Show("Enter Age with Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        user.Username = txt_username.Text;
        user.Password = txt_password.Text;
        user.Email = txt_email.Text;

        DialogResult =  DialogResult.OK;
    }

    public User GetUser() => user;

    private void btn_cancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
