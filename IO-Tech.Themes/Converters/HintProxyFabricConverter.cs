﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using IO_Tech.Themes.CustomControls.CustomSmartHint;
using IO_Tech.Themes.Helpers;

namespace IO_Tech.Themes.Converters
{
    /// <summary>
    /// Converter for <see cref="SmartHint"/> control. Can be extended by <see cref="HintProxyFabric.RegisterBuilder(Func{Control, bool}, Func{Control, IHintProxy})"/> method.
    /// </summary>
    public class HintProxyFabricConverter : IValueConverter
    {
        private static readonly Lazy<HintProxyFabricConverter> _instance = new Lazy<HintProxyFabricConverter>();

        public static HintProxyFabricConverter Instance => _instance.Value;

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return HintProxyFabric.Get(value as Control);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => Binding.DoNothing;
    }
}
