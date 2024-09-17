using System;

namespace SignalRApi.DAL
{
	public enum ECar
	{
		Bmw320i= 1,
		mercedesc180=2,
		fiategea=3,
		fiategeacross=4,
		volkswagenpolo=5,
	}
	public class Visitor
	{
		public int VisitorID {  get; set; }
		public ECar Car {  get; set; }
		public int CarRentCount { get; set; }
		public DateTime Date { get; set; }
	}
}
