namespace TableDbContextSample.Entities
{
    public class Cell
    {
        public int RowId { get; set; }
        public string ColumnName { get; set; }
        public int TableId { get; set; }

        public string CellValue { get; set; }

        public Column Column { get; set; }
        public Row Row { get; set; }
    }
}
