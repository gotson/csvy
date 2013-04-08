using System.Data;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace Csvy.Plugin.Helpers
{
    public static class CsvHelper
    {
        public static DataTable ReadCsvFile(string FileName, bool HasHeaders,char Delimiter, char Quote, char Escape, char Comment)
        {
            DataTable table = new DataTable();

            using (FileStream fs = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    using (CsvReader csv = new CsvReader(reader, HasHeaders,Delimiter,Quote,Escape,Comment, ValueTrimmingOptions.None))
                    {
                        csv.DefaultParseErrorAction = ParseErrorAction.AdvanceToNextLine;
                        csv.MissingFieldAction = MissingFieldAction.ReplaceByEmpty;
                        csv.SkipEmptyLines = true;

                        if (HasHeaders)
                        {
                            foreach (string header in csv.GetFieldHeaders())
                            {
                                if (header != null && header.Length > 0 && !table.Columns.Contains(header))
                                {
                                    table.Columns.Add(header, typeof(string));
                                }
                                else
                                    table.Columns.Add();
                            }
                        }

                        // add columns if a record has more fields than the headers
                        while (csv.FieldCount > table.Columns.Count)
                                table.Columns.Add();

                        while (csv.ReadNextRecord())
                        {
                            string[] row = new string[csv.FieldCount];
                            csv.CopyCurrentRecordTo(row);                        
                            table.Rows.Add(row);
                        }
                    }
                }
            }

            return table;
        }

        public static string[] CsvStringToArray(string csvString)
        {
            using (StringReader reader = new StringReader(csvString))
            {
                using (CsvReader csv = new CsvReader(reader, false))
                {
                    csv.DefaultParseErrorAction = ParseErrorAction.AdvanceToNextLine;
                    csv.MissingFieldAction = MissingFieldAction.ReplaceByEmpty;
                    csv.SkipEmptyLines = true;

                    string[] a = new string[csv.FieldCount];
                    while (csv.ReadNextRecord())
                    {
                        csv.CopyCurrentRecordTo(a);
                    }

                    return a;
                }
            }
        }
    }
}
