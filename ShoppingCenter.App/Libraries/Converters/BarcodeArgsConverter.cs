using System.Globalization;
using ZXing.Net.Maui;

namespace ShoppingCenter.App.Libraries.Converters;

public class BarcodeArgsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not BarcodeDetectionEventArgs args)
            return null;

        return args.Results[0].Value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
