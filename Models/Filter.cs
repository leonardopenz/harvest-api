using System;

namespace harvest_api.Models
{
    public class Filter
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public String orchards { get; set; }
        public ReportTabs tab { get; set; }
    }

    public enum ReportTabs : byte
    {
        Varieties = 0,
        Orchards = 1
    }
}
