namespace MauiTabQueryRepro;

public partial class FavoritesPage : ContentPage
{
	public FavoritesPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel<FavoritesPage>();
	}
}