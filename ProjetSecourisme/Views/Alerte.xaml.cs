namespace ProjetSecourisme.Views;
public partial class Alerte : ContentPage
{

    public Alerte()
    {
        InitializeComponent();
    }
    private async void yes(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(respiration), true);

    }
    private async void no(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(respiration), true);

    }
}