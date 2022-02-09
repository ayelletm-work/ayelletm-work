using System;
using System.Collections.Generic;
using System.Windows;

namespace IO_Tech.client.ViewModels
{
    public class HeaderViewModel : ViewModelBase
    {
        private readonly Type _contentType;
        private readonly object? _dataContext;

        private object? _content;

        public HeaderViewModel(string name, Type contentType, IEnumerable<NavItemType> documentation,
            object? dataContext = null)
        {
            Name = name;
            _contentType = contentType;
            _dataContext = dataContext;
            Documentation = documentation;
        }

        public string Name { get; }

        public IEnumerable<NavItemType> Documentation { get; }

        public object? Content => _content ??= CreateContent();


        private object? CreateContent()
        {
            var content = Activator.CreateInstance(_contentType);
            if (_dataContext != null && content is FrameworkElement element) element.DataContext = _dataContext;

            return content;
        }
    }
}