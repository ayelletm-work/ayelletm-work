using System.Collections.ObjectModel;
using IO_Tech.client.Helpers;
using IO_Tech.client.Models;
using IO_Tech.Themes.CustomControls.CustomPackIcon;

namespace IO_Tech.client.ViewModels.Components
{
    public class HistoryViewModel : ViewModelBase
    {
        public ObservableCollection<HistoryItem> HistoryItems { get; set; } = new ObservableCollection<HistoryItem>
        {
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Info,
                Icon = PackIconKind.InfoCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Info,
                Icon = PackIconKind.InfoCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Warning,
                Icon = PackIconKind.AlertCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Neutral,
                Icon = PackIconKind.CogOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Error,
                Icon = PackIconKind.CloseCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Error,
                Icon = PackIconKind.CloseCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Warning,
                Icon = PackIconKind.AlertCircleOutline,
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Neutral,
                Icon = PackIconKind.CogOutline,
            }
        };

        #region Initialize view model

        #endregion
    }
}