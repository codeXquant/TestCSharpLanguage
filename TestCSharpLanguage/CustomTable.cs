using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpLanguage
{
    public class CustomTable
    {
        public static DataTable GetTable(string tableName)
        {
            var table = CreateTable(tableName);
            CreateColumns(table);
            CreateRows(table);
            return table;
        }
        public static DataTable GetTable()
        {
            var table = CreateTable();
            CreateColumns(table);
            CreateRows(table);
            return table;
        }
        public static DataTable CreateTable()
        {
            //创建一个空表
            var table = new DataTable();
            return table;
        }
        public static DataTable CreateTable(string tableName)
        {
            //创建一个名为"Table_New"的空表
            var table = new DataTable("Table_New");
            return table;
        }
        public static void CreateColumns(DataTable table)
        {
            string[] columns = new string[] { "column0", "column1", "column2", "column3", "column4", "column5", "column6" };
            string[] columnTypes = new string[] { "String", "String", "String", "String", "String", "String", "String" };
            CreateColumns(table, columns, columnTypes);
            CreateRows(table);
        }
        public static void CreateColumns(DataTable table, string[] columns, string[] columnsType)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                //创建带列名和类型名的列
                table.Columns.Add(columns[i], System.Type.GetType(columnsType[i]));
            }
        }
        public static void CreateRows(DataTable table)
        {
            List<string[]> rows = new List<string[]>
            {
                new string[]{"","","","","","",""},
            };
            CreateRows<string[]>(table, rows);
        }

        public static void CreateRows<T>(DataTable table, IEnumerable<T> enitys) where T : class
        {
            DataRow dr = table.NewRow();
            foreach (var enity in enitys)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {

                }
            }
        }
    }
}
