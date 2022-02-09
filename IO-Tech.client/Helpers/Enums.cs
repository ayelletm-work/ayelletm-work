using System.ComponentModel;

namespace IO_Tech.client.Helpers
{
    public enum NavItemType
    {
        [Description("Dashboard")]
        Dashboard,
        [Description("Job Queue")]
        JobQueue,
        [Description("Operational")]
        Operational,
        [Description("Calibration")]
        Calibration,
        [Description("Log")]
        Log,
    }

    public enum SeverityType
    {
        [Description("Error")]
        Error,
        [Description("Warning")]
        Warning,
        [Description("Info")]
        Info,
        [Description("neutral")]
        Neutral
    }
    public enum PriorityType
    {
        [Description("Error")]
        Error,
        [Description("Warning")]
        Warning,
        [Description("Info")]
        Info,
        [Description("neutral")]
        neutral
    }
}