using IO_Tech.client.Helpers;

namespace IO_Tech.client.Models
{
    public class JobItem
    {
        public PrintStatusType PrintStatusType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Path { get; set; }
        public int TotalCount { get; set; }
        public int Count { get; set; }
        public int Layer { get; set; }
        public int Tile { get; set; }
        public string Status { get; set; }
    }
}