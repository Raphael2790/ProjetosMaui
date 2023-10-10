using AppMAUIGallery.Resources.Styles;

namespace AppMAUIGallery.Views.Styles;

public partial class Theme : ContentPage
{
	private bool _isLight = true;

	public Theme()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var dictionaries = Application.Current.Resources.MergedDictionaries;

		if (dictionaries is not null && dictionaries.Any())
		{
			dictionaries.Remove(dictionaries.ElementAt(2));

			if (_isLight)
			{
				_isLight = !_isLight;
				dictionaries.Add(new DarkTheme());
			}
			else
			{
                _isLight = !_isLight;
                dictionaries.Add(new LightTheme());
            }
		}
    }
}