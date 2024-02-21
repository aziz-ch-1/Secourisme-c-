using ProjetSecourisme.Data;
using ProjetSecourisme.Models;

namespace ProjetSecourisme.Views;
//[QueryProperty("Item", "Item")]

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }
    //private readonly Database database;
    //public SignupS Item
    //{
    //    get => BindingContext as SignupS;
    //    set => BindingContext = value;
    //}
    //public SignupPage(Database database)
    //{
    //    InitializeComponent();
    //    this.database = database;
    //}
    //protected override void OnAppearing()
    //{
    //    if (Item.Id_S == 1)
    //    {
    //        Title = "new user";
    //    }

    //    base.OnAppearing();
    //}
    //private async void Save(object sender, EventArgs e)
    //{
    //    if (((Item.Email).Length == 0))
    //    {
    //        await DisplayAlert("champs obligatoire", "invalide ", "OK");
    //        return;
    //    }

    //    await database.SaveUserAsync(Item);
    //    await Shell.Current.GoToAsync(nameof(SignInPage), true);


    //}
    ////private void PasswordFocused(object sender, FocusEventArgs e)
    ////{
    ////    if (e.IsFocused)
    ////        ((Entry)sender).IsPassword = false;
    ////    else
    ////        ((Entry)sender).IsPassword = true;
    ////}
}