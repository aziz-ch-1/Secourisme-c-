using ProjetSecourisme.Data;
using ProjetSecourisme.Models;

namespace ProjetSecourisme.Views;

[QueryProperty("Item", "Item")]
public partial class LoginItemPage : ContentPage
{
    private readonly Database database;
    public Login Item
    {
        get => BindingContext as Login;
        set => BindingContext = value;
    }
    public LoginItemPage(Database database)
    {
        InitializeComponent();
        this.database = database;
    }
    protected override void OnAppearing()
    {
        if (Item.Id == 0)
        {
            Title = "Ajouter utilisateur";
        }

        base.OnAppearing();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Item.Website))
        {
            await DisplayAlert("Site obligatoire", "Veuillez entrer le nom d'un site web pour continuer", "OK");
            return;
        }

        await database.SaveItemAsync(Item);
        await Shell.Current.GoToAsync("..", true);


    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..", true);
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.Id == 0)
            return;

        var answer = await DisplayAlert("Alerte", "�tes-vous s�r de vouloir supprimer ce mot de passe ?", "Oui", "Non");

        if (answer)
        {
            await database.DeleteItemAsync(Item);
            await Shell.Current.GoToAsync("..", true);
        }
    }

    private void OnPasswordFocused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused)
            ((Entry)sender).IsPassword = false;
        else
            ((Entry)sender).IsPassword = true;
    }




}