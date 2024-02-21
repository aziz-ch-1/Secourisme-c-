using SQLite;

namespace ProjetSecourisme.Models
{
    public class Login
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Website { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Login() { }

        public Login(int id, string website, string username, string password)
        {
            Id = id;
            Website = website;
            Username = username;
            Password = password;
        }
    }
}
