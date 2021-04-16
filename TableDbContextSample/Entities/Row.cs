using System.Collections.Generic;

namespace TableDbContextSample.Entities
{
    public class Row
	{
		public int Id { get; set; }
		public List<Cell> Cells { get; set; }
		public int TableId { get; set; }

		public Table Table { get; set; }
	}
}
