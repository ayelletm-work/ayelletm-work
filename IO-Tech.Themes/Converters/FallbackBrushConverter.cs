using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;

namespace IO_Tech.Themes.Converters
{
    internal class FallbackBrushConverter : IMultiValueConverter
    {
        public object? Convert(object?[]? values, Type targetType, object? parameter, CultureInfo culture)
        {
            return values?.OfType<SolidColorBrush>()
                .FirstOrDefault(x => x.Color != default && x.Color != Colors.Transparent);
        }

        public object?[]? ConvertBack(object? value, Type[] targetTypes, object? parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}