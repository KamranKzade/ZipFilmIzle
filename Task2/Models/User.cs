namespace ZipFilmIzle.Models;

public class User
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public byte? Age { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }

    public User() { }


    public User(string? name, string? surname, byte? age, string? username, string? password, string? email)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Username = username;
        Password = password;
        Email = email;
    }

}
