namespace MauiTabQueryRepro;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewPage), typeof(NewPage));
	}
}
