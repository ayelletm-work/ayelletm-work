using System.Windows;
using System.Windows.Media.Animation;

namespace IO_Tech.Themes.Transitions
{
    public interface ITransitionEffect
    {
        Timeline? Build<TSubject>(TSubject effectSubject) where TSubject : FrameworkElement, ITransitionEffectSubject;
    }
}