using System.Collections.Generic;

namespace SignalRApiForSql.Models
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Counts = new List<int>();
        }
        public string Date { get; set; }
        public List<int> Counts { get; set; }
    }
}
