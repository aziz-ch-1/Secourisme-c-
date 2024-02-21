using ProjetSecourisme.Models;

namespace ProjetSecourisme.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }
    //private async void Signup(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync(nameof(LoginItemPage), true);

    //}
    private async void Signup(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new Login()
        });
    }
    private async void SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage), true);

    }
    private async void btAlerte(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Alerte), true);

    }
    private async void doc(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Documentation), true);

    }
   
}