using ShoppingCenter.Models;
using System.Globalization;

namespace ShoppingCenter.App.Libraries.Converters;

public class TimeSpanToTimeStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Ticket ticket)
        {
            var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
            var difTS = new TimeSpan(dif);

            return string.Format("{0:D2}h {01:D2}m", difTS.Hours, difTS.Minutes);
        }

        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string timeString)
        {
            return TimeSpan.Parse(timeString);
        }

        return TimeSpan.Zero;
    }
}