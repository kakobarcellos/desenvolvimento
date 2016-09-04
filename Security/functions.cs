using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.Web;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections;
using System.Xml.Serialization;
using System.Net.Mail;

namespace Security
{
    public static class functions
    {

        public static string DataTableToJson(DataTable table, Boolean comColchete = false)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in table.Rows)
            {
                if (sb.Length != 0)
                    sb.Append(",");
                sb.Append("{");
                StringBuilder sb2 = new StringBuilder();
                foreach (DataColumn col in table.Columns)
                {
                    string fieldname = col.ColumnName;
                    string fieldvalue = dr[fieldname].ToString();
                    if (sb2.Length != 0)
                        sb2.Append(",");
                    if (col.DataType == typeof(System.DateTime) && !String.IsNullOrEmpty(fieldvalue))
                    {
                        sb2.Append(string.Format("\"{0}\":\"{1}\"", fieldname, Convert.ToDateTime(fieldvalue).ToString("dd/MM/yyyy")));
                    }
                    else if (col.DataType == typeof(System.Boolean) && !String.IsNullOrEmpty(fieldvalue))
                    {
                        if (Convert.ToBoolean(fieldvalue) == true)
                        {
                            sb2.Append(string.Format("\"{0}\":\"{1}\"", fieldname, "1"));
                        }
                        else
                        {
                            sb2.Append(string.Format("\"{0}\":\"{1}\"", fieldname, "0"));
                        }

                    }
                    else
                    {
                        fieldvalue = fieldvalue.Replace("\n", "\\n");
                        fieldvalue = fieldvalue.Replace("\t", "\\t");
                        sb2.Append(string.Format("\"{0}\":\"{1}\"", fieldname, fieldvalue));
                    }


                }
                sb.Append(sb2.ToString());
                sb.Append("}");
                
            }

            if (comColchete)
            {
                sb.Insert(0, "[");
                sb.Append("]");
            }

            return sb.ToString();
        }

    }
}
