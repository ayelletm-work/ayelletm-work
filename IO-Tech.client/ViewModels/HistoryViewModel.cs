using System.Collections.ObjectModel;
using IO_Tech.client.Helpers;
using IO_Tech.client.Models;

namespace IO_Tech.client.ViewModels
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
                SeverityType = SeverityType.Info
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Info
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Warning
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Neutral
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Error
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Warning
            },
            new HistoryItem
            {
                Name = "Printing",
                Description =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.",
                SeverityType = SeverityType.Neutral
            }
        };

        #region Initialize view model

        #endregion
    }
}