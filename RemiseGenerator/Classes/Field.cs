using System;

namespace RemiseGenerator
{
    public class Field
    {
        public string name { get; set; }
        public string valueType { get; set; }
        public int length { get; set; }
        public string defaultValue { get; set; }

        public Field()
        {
        }
    }
}