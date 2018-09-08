using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Dal.Common
{
    /// <summary>
    /// 表格帮助类
    /// </summary>
    public sealed class TableHelp
    {
        public static DataSet ImportTables()
        {
            return null;
        }
        public static DataTable ImportTable()
        {
            return null;
        }
        public static void ExportTable(string pathFile, DataSet table)
        {

        }
        public static void ExportTable(string pathFile, DataTable table)
        {

        }
        public static void ExportTable(string pathFile, IEnumerable<string> writeLine)
        {

        }
        public static void ExportTable(string pathFile, IEnumerable<byte[]> bytes)
        {

        }
        public static void ExportCsvFile(string pathFile,IEnumerable<string> lines,Encoding encoding)
        {
            using (var stream = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(stream, encoding))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                    writer.Flush();
                }
            }
        }
        public static void ExportCsvFile(string pathFile, IEnumerable<byte[]> bytes)
        {
            using (var stream = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                foreach (var buff in bytes)
                {
                    stream.Write(buff, 0, buff.Length);
                }
                stream.Flush();
            }
        }
    }
}
