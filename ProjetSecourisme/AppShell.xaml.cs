using ProjetSecourisme.Views;

namespace ProjetSecourisme;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(respiration), typeof(respiration));
        Routing.RegisterRoute(nameof(Documentation), typeof(Documentation));
        Routing.RegisterRoute(nameof(questionnaire), typeof(questionnaire));
        Routing.RegisterRoute(nameof(LoginItemPage), typeof(LoginItemPage));
        Routing.RegisterRoute(nameof(LoginListPage), typeof(LoginListPage));
        Routing.RegisterRoute(nameof(Alerte), typeof(Alerte));
        Routing.RegisterRoute(nameof(Home), typeof(Home));
        Routing.RegisterRoute(nameof(SignupPage), typeof(SignupPage));
        Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));

    }
}
