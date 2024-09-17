using System.Collections.Generic;

namespace SignalRApi.Model
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
