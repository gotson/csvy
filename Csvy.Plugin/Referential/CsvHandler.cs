using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Csvy.Plugin.Helpers;
using LumenWorks.Framework.IO.Csv;

namespace Csvy.Plugin.Referential
{
    public class CsvHandler
    {
        #region Constants
        /// <summary>
        /// Composite primary key
        /// </summary>
        public const string PRIMARY_KEY_TEMPLATE = "ID";

        #endregion

        #region Private members
        private DateTime lastUpdate = DateTime.MinValue;
        private DataTable referential;
        private string fileName;
        private string primaryKeyExtension = String.Empty;
        private string primaryKey = PRIMARY_KEY_TEMPLATE;
        private bool csvHasHeaders = true;
        private char csvDelimiter = CsvReader.DefaultDelimiter;
        private char csvQuote = CsvReader.DefaultQuote;
        private char csvEscape = CsvReader.DefaultEscape;
        private char csvComment = CsvReader.DefaultComment;
        private List<string> headers = new List<string>();
        #endregion

        #region Constructors
        /// <summary>
        /// Creates an empty instance of ReferentialManager
        /// </summary>
        public CsvHandler() { }

        /// <summary>
        /// Creates a new instance of ReferentialManager
        /// </summary>
        /// <param name="fileName">CSV file containing the referential elements</param>
        /// <param name="primaryKeyExtension">Column name that will be added to the numerical ID to create the Primary Key</param>
        public CsvHandler(string fileName, string primaryKeyExtension)
        {
            this.fileName = fileName;
            this.primaryKeyExtension = primaryKeyExtension;
            refresh(true);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Primary Key
        /// </summary>
        public string PrimaryKey
        {
            get { return primaryKey; }
        }

        /// <summary>
        /// Column name that will be added to the numerical ID to create the Primary Key
        /// </summary>
        public string PrimaryKeyExtension
        {
            get { return primaryKeyExtension; }
            set
            {
                if (primaryKeyExtension != value)
                {
                    primaryKeyExtension = value;
                    refresh(true);
                }
            }
        }

        /// <summary>
        /// CSV file containing the referential elements
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (fileName != value)
                {
                    fileName = value;
                    refresh(true);
                }
            }
        }

        public bool CsvHasHeaders
        {
            get { return csvHasHeaders; }
            set
            {
                if (csvHasHeaders != value)
                {
                    csvHasHeaders = value;
                    refresh(true);
                }
            }
        }

        public char CsvDelimiter
        {
            get { return csvDelimiter; }
            set
            {
                if (csvDelimiter != value)
                {
                    csvDelimiter = value;
                    refresh(true);
                }
            }
        }

        public char CsvQuote
        {
            get { return csvQuote; }
            set
            {
                if (csvQuote != value)
                {
                    csvQuote = value;
                    refresh(true);
                }
            }
        }

        public char CsvEscape
        {
            get { return csvEscape; }
            set
            {
                if (csvEscape != value)
                {
                    csvEscape = value;
                    refresh(true);
                }
            }
        }

        public char CsvComment
        {
            get { return csvComment; }
            set
            {
                if (csvComment != value)
                {
                    csvComment = value;
                    refresh(true);
                }
            }
        }

        public List<string> Headers
        {
            get { return headers; }
        }

        /// <summary>
        /// Get all the elements in the referential
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public DataRowCollection Rows
        {
            get
            {
                return referential.Rows;
            }
        }

        /// <summary>
        /// Get one element of the referential
        /// </summary>
        /// <param name="id">ID of the element</param>
        /// <returns></returns>
        [System.Xml.Serialization.XmlIgnore]
        public DataRow this[string id]
        {
            get
            {
                string expression = primaryKey + "='" + id + "'";
                DataRow[] foundRows;
                // Use the Select method to find all rows matching the filter.
                foundRows = referential.Select(expression);
                return foundRows[0];
            }
        }
        #endregion

        #region Public Functions
        /// <summary>
        /// Refreshes the cache from disk if needed
        /// </summary>
        public void Refresh()
        {
            refresh(false);
        }
        #endregion

        #region Private Functions
        /// <summary>
        /// Refreshes the cache from disk if needed. Can be forced.
        /// </summary>
        /// <param name="force">Forces the refresh of the referential, even if the file has not changed</param>
        private void refresh(bool force)
        {
            if (string.IsNullOrEmpty(fileName))
                return;
            try
            {
                FileInfo fi = new FileInfo(fileName);
                if (force || fi.LastWriteTime > lastUpdate)
                {
                    DataTable newReferential = CsvHelper.ReadCsvFile(fileName, csvHasHeaders, csvDelimiter, csvQuote, csvEscape, csvComment);

                    DataColumn[] keys = new DataColumn[1];
                    while (newReferential.Columns.Contains(primaryKey))
                    {
                        primaryKey = "_" + primaryKey;
                    }
                    DataColumn column = new DataColumn(primaryKey, typeof(string));

                    // add column for primary key
                    newReferential.Columns.Add(column);

                    // fill the primary key column
                    int i = 1;
                    foreach (DataRow row in newReferential.Rows)
                    {
                        if (string.IsNullOrEmpty(primaryKeyExtension))
                            row[primaryKey] = i;
                        else
                            try
                            {
                                row[primaryKey] = i + "." + SearchHelper.ReplaceMaskWithItem(primaryKeyExtension, row);
                            }
                            catch (Exception)
                            {
                                row[primaryKey] = i;
                            }
                        i++;
                    }

                    // set primary key
                    keys[0] = column;
                    newReferential.PrimaryKey = keys;

                    referential = newReferential;

                    // refresh headers
                    try
                    {
                        headers = new List<string>();
                        foreach (DataColumn c in referential.Columns)
                            headers.Add(c.ColumnName);
                    }
                    catch (Exception)
                    {
                        headers = new List<string>();
                    }

                    lastUpdate = DateTime.MinValue;
                }
            }
            catch (Exception) { }
        }
        #endregion
    }
}
