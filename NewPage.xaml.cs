namespace MauiTabQueryRepro;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel<NewPage>();
	}
}