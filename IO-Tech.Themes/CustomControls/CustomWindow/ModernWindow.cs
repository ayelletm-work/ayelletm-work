using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace IO_Tech.Themes.CustomControls.CustomWindow
{
    /// <summary>
    /// Represents a Modern UI styled window.
    /// </summary>
    public class ModernWindow
        : Window
    {
        /// <summary>
        /// Identifies the BackgroundContent dependency property.
        /// </summary>
        public static readonly DependencyProperty BackgroundContentProperty = DependencyProperty.Register("BackgroundContent", typeof(object), typeof(ModernWindow));
            /// <summary>
        /// Identifies the IsTitleVisible dependency property.
        /// </summary>
        public static readonly DependencyProperty IsTitleVisibleProperty = DependencyProperty.Register("IsTitleVisible", typeof(bool), typeof(ModernWindow), new PropertyMetadata(false));
        /// <summary>
        /// Identifies the LogoData dependency property.
        /// </summary>
        public static readonly DependencyProperty LogoDataProperty = DependencyProperty.Register("LogoData", typeof(Geometry), typeof(ModernWindow));
       
        private Storyboard backgroundAnimation;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModernWindow"/> class.
        /// </summary>
        public ModernWindow()
        {
            this.DefaultStyleKey = typeof(ModernWindow);

          
            // associate window commands with this instance
 
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, OnCloseWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, OnMaximizeWindow, OnCanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, OnMinimizeWindow, OnCanMinimizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, OnRestoreWindow, OnCanResizeWindow));
   
        }

        /// <summary>
        /// Raises the System.Windows.Window.Closed event.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
 
        }

        /// <summary>
        /// When overridden in a derived class, is invoked whenever application code or internal processes call System.Windows.FrameworkElement.ApplyTemplate().
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // retrieve BackgroundAnimation storyboard
            if (GetTemplateChild("WindowBorder") is Border border)
            {
                this.backgroundAnimation = border.Resources["BackgroundAnimation"] as Storyboard;

                backgroundAnimation?.Begin();
            }
        }

        private void OnAppearanceManagerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // start background animation if theme has changed
            if (e.PropertyName == "ThemeSource")
            {
                backgroundAnimation?.Begin();
            }
        }

       

    

        private void OnCanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode == ResizeMode.CanResize || this.ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        private void OnCanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = this.ResizeMode != ResizeMode.NoResize;
        }

        private void OnCloseWindow(object target, ExecutedRoutedEventArgs e)
        {
 
            SystemCommands.CloseWindow(this);
 
        }

        private void OnMaximizeWindow(object target, ExecutedRoutedEventArgs e)
        {
 
            SystemCommands.MaximizeWindow(this);
 
        }

        private void OnMinimizeWindow(object target, ExecutedRoutedEventArgs e)
        {
 
            SystemCommands.MinimizeWindow(this);
 
        }

        private void OnRestoreWindow(object target, ExecutedRoutedEventArgs e)
        {
 
            SystemCommands.RestoreWindow(this);
 
        }

        /// <summary>
        /// Gets or sets the background content of this window instance.
        /// </summary>
        public object BackgroundContent
        {
            get => GetValue(BackgroundContentProperty);
            set => SetValue(BackgroundContentProperty, value);
        }

       
        /// <summary>
        /// Gets or sets a value indicating whether the window title is visible in the UI.
        /// </summary>
        public bool IsTitleVisible
        {
            get => (bool)GetValue(IsTitleVisibleProperty);
            set => SetValue(IsTitleVisibleProperty, value);
        }

        /// <summary>
        /// Gets or sets the path data for the logo displayed in the title area of the window.
        /// </summary>
        public Geometry LogoData
        {
            get => (Geometry)GetValue(LogoDataProperty);
            set => SetValue(LogoDataProperty, value);
        }
 

       
    }
}
