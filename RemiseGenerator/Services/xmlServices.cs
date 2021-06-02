using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RemiseGenerator
{
    public class xmlServices
    {
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
        // lecture des lignes
        public void readRows(List<Row> rows,List<string>lstDATA)
        {
            List<string>rowsList = new List<string>();
            foreach (Row row in rows)
            {
                readRow(row, lstDATA);
            }
            //return rowsList;
        }

        // lecture d'une seule ligne
        public void readRow(Row row, List<string> lstDATA)
        {
            String rowStr = string.Empty;
            int rowCount = row.instance;
            for (int i = 1; i <= rowCount; i++)
            {
                foreach (Field field in row.Fields)
                {
                    rowStr += readField(field);
                }
                lstDATA.Add(rowStr);
                rowStr = "";
            }            
            foreach (Row rowIn in row.Rows)
            {
                readRow(rowIn,lstDATA);
            }
        }

        // lecture d'un champ
        public string readField(Field field)
        {
            string value = string.Empty;
            if (!field.defaultValue.Equals(""))
            {
                String[] values = field.defaultValue.ToString().Split(',');                    
                value = values[0];
            }
            else
            {
                if (field.valueType.Equals("AN") || field.valueType.Equals("A"))
                {
                    value= string.Concat(Enumerable.Repeat("A", field.length));
                }
                else
                {
                    value = string.Concat(Enumerable.Repeat("0", field.length));
                }
            }
            return value;
        }
    }
}
