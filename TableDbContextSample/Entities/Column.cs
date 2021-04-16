namespace TableDbContextSample.Entities
{
    public class Column
	{
		public string Name { get; set; }
		public int TableId { get; set; }

		public Table Table { get; set; }
	}
}
