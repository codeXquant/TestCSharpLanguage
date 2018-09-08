using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            // 接收泛型返回值lambda表达式
            Func<DataTable, IEnumerable<string>> lines = x => GeWriteLine(x);
            var table = new DataTable();
            foreach(var line in lines(table))
            {
                Console.WriteLine(string.Format("返回值：{0}", line));
            }
            List<string[]> vs = new List<string[]>();
            Console.ReadLine();
        }

        public static IEnumerable<string> GeWriteLine(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                yield return string.Join(",", row.ItemArray);
            }
        }
    }
}
