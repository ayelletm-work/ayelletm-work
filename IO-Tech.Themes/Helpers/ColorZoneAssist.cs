﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace IO_Tech.Themes.Helpers
{
    public static class ColorZoneAssist
    {
        public static readonly DependencyProperty ModeProperty = DependencyProperty.RegisterAttached(
            "Mode", typeof(ColorZoneMode), typeof(ColorZoneAssist), new FrameworkPropertyMetadata(default(ColorZoneMode), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetMode(DependencyObject element, ColorZoneMode value)
        {
            element.SetValue(ModeProperty, value);
        }

        public static ColorZoneMode GetMode(DependencyObject element)
        {
            return (ColorZoneMode)element.GetValue(ModeProperty);
        }

        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            "Background", typeof(Brush), typeof(ColorZoneAssist), new FrameworkPropertyMetadata(default(Brush)));

        public static void SetBackground(DependencyObject element, Brush value)
        {
            element.SetValue(BackgroundProperty, value);
        }

        public static Brush GetBackground(DependencyObject element)
        {
            return (Brush)element.GetValue(BackgroundProperty);
        }

        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached(
            "Foreground", typeof(Brush), typeof(ColorZoneAssist), new FrameworkPropertyMetadata(default(Brush)));

        public static void SetForeground(DependencyObject element, Brush value)
        {
            element.SetValue(ForegroundProperty, value);
        }

        public static Brush GetForeground(DependencyObject element)
        {
            return (Brush)element.GetValue(ForegroundProperty);
        }
    }
}
