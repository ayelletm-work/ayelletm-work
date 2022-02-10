using System.Collections.ObjectModel;
using IO_Tech.client.Helpers;
using IO_Tech.client.Models;

namespace IO_Tech.client.ViewModels.Components
{
    public class ReadyForPrintViewModel : ViewModelBase
    {
        public ObservableCollection<JobItem> JobItems { get; set; } = new ObservableCollection<JobItem>
        {
            new JobItem
            {
                PrintStatusType = PrintStatusType.Done,
                Id = 1,
                Name = "ASM_33",
                Class = "IO.Tech.Infra.Devices.BaseCamera",
                Path = "IO.Tech.Infra.Devices.BaseCamera",
                TotalCount = 5,
                Count = 1,
                Layer = 2,
                Tile = 12,
                Status = "Ready"
            },
            new JobItem
            {
                PrintStatusType = PrintStatusType.Done,
                Id = 1,
                Name = "ASM_33",
                Class = "IO.Tech.Infra.Devices.BaseCamera",
                Path = "IO.Tech.Infra.Devices.BaseCamera",
                TotalCount = 5,
                Count = 1,
                Layer = 2,
                Tile = 12,
                Status = "Ready"
            },
            new JobItem
            {
                PrintStatusType = PrintStatusType.Done,
                Id = 1,
                Name = "ASM_33",
                Class = "IO.Tech.Infra.Devices.BaseCamera",
                Path = "IO.Tech.Infra.Devices.BaseCamera",
                TotalCount = 5,
                Count = 1,
                Layer = 2,
                Tile = 12,
                Status = "Ready"
            },
            new JobItem
            {
                PrintStatusType = PrintStatusType.Done,
                Id = 1,
                Name = "ASM_33",
                Class = "IO.Tech.Infra.Devices.BaseCamera",
                Path = "IO.Tech.Infra.Devices.BaseCamera",
                TotalCount = 5,
                Count = 1,
                Layer = 2,
                Tile = 12,
                Status = "Ready"
            }
        };
    }
}