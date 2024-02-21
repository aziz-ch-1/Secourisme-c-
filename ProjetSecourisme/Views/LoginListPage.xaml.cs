using ProjetSecourisme.Data;
using ProjetSecourisme.Models;
using System.Collections.ObjectModel;


namespace ProjetSecourisme.Views;

public partial class LoginListPage : ContentPage
{
    private readonly Database database;

    public ObservableCollection<Login> Items { get; set; } = new();
    public  LoginListPage(Database database)
    {
        InitializeComponent();
        this.database = database;

        BindingContext = this;
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        var items = await database.GetItemsAsync();

        MainThread.BeginInvokeOnMainThread(() =>
        {
            Items.Clear();
            foreach (var item in items)
                Items.Add(item);
        });
    }
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Login item)
            return;

        await Shell.Current.GoToAsync(nameof(LoginItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });

    }
    private async void OnItemAdd(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new Login()
        });
    }
    private async void AddAlerte(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Alerte), true, new Dictionary<string, object>
        {
            ["Item"] = new Login()
        });
    }


}

