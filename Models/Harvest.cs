using System;

namespace harvest_api.Models
{
    public class Harvest
    {
        public String id { get; set; }
        public String userId { get; set; }
        public String varietyId { get; set; }
        public String varietyName { get; set; }
        public String orchardId { get; set; }
        public String orchardName { get; set; }
        public DateTime pickingDate { get; set; }
        public int numberOfBins { get; set; }
        public decimal hoursWorked { get; set; }
        public decimal payRateByHour { get; set; }
    }
}
