namespace MauiTabQueryRepro;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel<SettingsPage>();
	}
}