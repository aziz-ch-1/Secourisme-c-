namespace ProjetSecourisme.Views;

public partial class respiration : ContentPage
{
	public respiration()
	{
		InitializeComponent();
	}
    private async void quest(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(questionnaire), true);

    }
    private async void guest(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(questionnaire), true);

    }
}