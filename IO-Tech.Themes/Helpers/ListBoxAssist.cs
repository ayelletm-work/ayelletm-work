using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using IO_Tech.Themes.CustomControls.CustomRipple;

namespace IO_Tech.Themes.Helpers
{
    public static class ListBoxAssist
    {
        static ListBoxAssist()
        {
            EventManager.RegisterClassHandler(typeof(ListBox), UIElement.PreviewMouseLeftButtonDownEvent,
                new MouseButtonEventHandler(ListBoxMouseButtonEvent));
        }

        private static void ListBoxMouseButtonEvent(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            var senderElement = (UIElement)sender;

            if (!GetIsToggle(senderElement)) return;

            var point = mouseButtonEventArgs.GetPosition(senderElement);
            var result = VisualTreeHelper.HitTest(senderElement, point);

            if (result is null) return;

            ListBoxItem? listBoxItem = null;
            Ripple? ripple = null;
            foreach (var dependencyObject in result.VisualHit.GetLogicalAncestry().TakeWhile(_ => listBoxItem is null))
            {
                listBoxItem = dependencyObject as ListBoxItem;
                if (ripple is null)
                    ripple = dependencyObject as Ripple;
            }

            if (listBoxItem is null || !listBoxItem.IsEnabled) return;

            listBoxItem.SetCurrentValue(ListBoxItem.IsSelectedProperty, !listBoxItem.IsSelected);
            mouseButtonEventArgs.Handled = true;

            if (ripple != null && listBoxItem.IsSelected)
            {
                ripple.RaiseEvent(
                    new MouseButtonEventArgs(mouseButtonEventArgs.MouseDevice, mouseButtonEventArgs.Timestamp, mouseButtonEventArgs.ChangedButton)
                    {
                        RoutedEvent = UIElement.PreviewMouseLeftButtonDownEvent,
                        Source = ripple
                    });
            }
        }

        public static readonly DependencyProperty IsToggleProperty = DependencyProperty.RegisterAttached(
            "IsToggle", typeof(bool), typeof(ListBoxAssist), new FrameworkPropertyMetadata(default(bool)));

        public static void SetIsToggle(DependencyObject element, bool value)
            => element.SetValue(IsToggleProperty, value);

        public static bool GetIsToggle(DependencyObject element)
            => (bool)element.GetValue(IsToggleProperty);
    }
}
