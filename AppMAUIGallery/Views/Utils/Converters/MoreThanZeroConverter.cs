using System.Globalization;

namespace AppMAUIGallery.Views.Utils.Converters;

public class MoreThanZeroConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var number = (int)value;
        return number > 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
