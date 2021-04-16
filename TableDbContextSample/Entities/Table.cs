using System.Collections.Generic;

namespace TableDbContextSample.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public List<Column> Columns { get; set; }
        public List<Row> Rows { get; set; }
    }
}
