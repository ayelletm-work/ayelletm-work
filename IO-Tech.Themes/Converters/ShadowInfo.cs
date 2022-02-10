using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Effects;
using IO_Tech.Themes.Helpers;

namespace IO_Tech.Themes.Converters
{
    internal static class ShadowInfo
    {
        private static readonly IDictionary<ShadowDepth, DropShadowEffect?> ShadowsDictionary;

        static ShadowInfo()
        {
            var resourceDictionary = new ResourceDictionary { Source = new Uri("/IO-Tech.Themes;component/Styles/Assets.xaml", UriKind.Absolute) };

            ShadowsDictionary = new Dictionary<ShadowDepth, DropShadowEffect?>
            {
                { ShadowDepth.Depth0, null },
                { ShadowDepth.Depth1, (DropShadowEffect)resourceDictionary["ShadowDepth1"] },
                { ShadowDepth.Depth2, (DropShadowEffect)resourceDictionary["ShadowDepth2"] },
                { ShadowDepth.Depth3, (DropShadowEffect)resourceDictionary["ShadowDepth3"] },
                { ShadowDepth.Depth4, (DropShadowEffect)resourceDictionary["ShadowDepth4"] },
                { ShadowDepth.Depth5, (DropShadowEffect)resourceDictionary["ShadowDepth5"] },
            };
        }

        public static DropShadowEffect? GetDropShadow(ShadowDepth depth)
            => ShadowsDictionary[depth];
    }
}