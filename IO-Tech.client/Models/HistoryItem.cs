using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Tech.client.Helpers;
using IO_Tech.Themes.CustomControls.CustomPackIcon;

namespace IO_Tech.client.Models
{
   public class HistoryItem
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public PackIconKind Icon { get; set; }

        public SeverityType SeverityType { get; set; }
    }
}
