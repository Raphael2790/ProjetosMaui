using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists;

public partial class BindableLayoutPage : ContentPage
{
	public BindableLayoutPage()
	{
		InitializeComponent();
		var layout = VerticalStackLayoutControl;
		var items = MovieList.GetList();

		BindableLayout.SetItemsSource(layout, items);
	}
}