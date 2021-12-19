using System;
using System.Collections.Generic;
using System.Linq;

namespace harvest_api.Models
{
    public class Report
    {
        public decimal totalProduction { get { return categories.Sum(x => x.production); } }
        public decimal totalCost { get { return Math.Round(categories.Sum(x => x.cost), 3); } }
        public List<ReportCategorie> categories { get; set; }
    }

    public class ReportCategorie
    {
        public string id { get; set; }
        public string name { get; set; }
        public decimal production { get; set; }
        public decimal cost { get; set; }
    }
}
