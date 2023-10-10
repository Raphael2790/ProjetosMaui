using AppMAUIGallery.Views.CommunityMaui.ViewModel;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class CommunityBehaviorsPage : ContentPage
{
	public CommunityBehaviorsPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
		var vm = (CommunityBehaviorsPageViewModel)BindingContext;

		if (vm.PressedCommand.CanExecute(null))
			vm.PressedCommand.Execute(null);
    }
}