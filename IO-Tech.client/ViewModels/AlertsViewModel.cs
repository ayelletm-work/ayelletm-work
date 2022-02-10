using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Tech.client.Helpers;
using IO_Tech.client.Models;
using IO_Tech.Themes.CustomControls.CustomPackIcon;

namespace IO_Tech.client.ViewModels
{
   public class AlertsViewModel : ViewModelBase
    {
        public ObservableCollection<AlertItem> AlertItems { get; set; } = new ObservableCollection<AlertItem>
        {
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Done,
                Icon = PackIconKind.CheckCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Done,
                Icon = PackIconKind.CheckCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Warning,
                Icon = PackIconKind.AlertCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Critical,
                Icon = PackIconKind.CloseCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Critical,
                Icon = PackIconKind.CloseCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Critical,
                Icon = PackIconKind.CloseCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Warning,
                Icon = PackIconKind.AlertCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            },
            new AlertItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                PrintStatusType = PrintStatusType.Done,
                Icon = PackIconKind.CheckCircleOutline,
                TimeStamp = "08:24 am ,Dec 12",
            }
        };

        #region Initialize view model

        #endregion
    }
}
