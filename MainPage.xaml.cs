namespace MauiTabQueryRepro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel<MainPage>();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		Dispatcher.DispatchAsync(() =>
			Shell.Current.GoToAsync(nameof(NewPage)));
	}
}

