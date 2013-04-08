using System;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Data;

namespace Csvy.Plugin.Helpers
{
    public static class SerializationHelper
    {
        /// <summary>
        /// Serializes any object to XML
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="obj">Object to serialize</param>
        /// <returns>XML representation</returns>
        public static string SerializeToXMLString<T>(T obj)
        {
            StringWriter sw = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(sw, obj);
            return sw.ToString();
        }

        /// <summary>
        /// Deserializes any object from XML
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="source">XML representation</param>
        /// <returns>Object</returns>
        public static object DeserializeFromXMLString<T>(string source)
        {
            StringReader sr = new StringReader(source);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            object obj = serializer.Deserialize(sr);
            return obj;
        }

        /// <summary>
        /// Encode a string using Base64
        /// </summary>
        /// <param name="str">string to encode</param>
        /// <returns>Base64 representation of the string</returns>
        public static string Encode64(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }

        /// <summary>
        /// Decode a string using Base64
        /// </summary>
        /// <param name="str">string to decode</param>
        /// <returns>Plain string</returns>
        public static string Decode64(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }

        public static string SerializeToJson(DataRow r)
        {
            int index = 0;
            StringBuilder json = new StringBuilder();
            foreach (DataColumn item in r.Table.Columns)
            {
                json.Append(String.Format("\"{0}\" : \"{1}\"", item.ColumnName, r[item.ColumnName].ToString()));
                if (index < r.Table.Columns.Count - 1)
                {
                    json.Append(", ");
                }
                index++;
            }
            return "{" + json.ToString() + "}";
        }
    }
}
