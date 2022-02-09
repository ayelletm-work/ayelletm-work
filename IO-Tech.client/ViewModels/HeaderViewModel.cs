using System;
using System.Collections.Generic;
using System.Windows;
using IO_Tech.client.Helpers;

namespace IO_Tech.client.ViewModels
{
    public class HeaderViewModel : ViewModelBase
    {
        readonly EnumListItemCollection<NavItemType> _navItems = new EnumListItemCollection<NavItemType>();

        private NavItemType _navItem;

        public EnumListItemCollection<NavItemType> navItems => _navItems;

        public NavItemType NavItem
        {
            get => _navItem;
            set => SetProperty(ref _navItem, value);
        }
    }
}