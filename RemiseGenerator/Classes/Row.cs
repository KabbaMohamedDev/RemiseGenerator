using System.Collections.Generic;

namespace RemiseGenerator
{
    public class Row
    {
        public int instance { get; set; }
        public List<Field> Fields { get; set; }
        public List<Row> Rows { get; set; }
        public Row()
        {
        }
    }
}