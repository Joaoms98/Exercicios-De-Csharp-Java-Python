using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Class1
    {
        public static string SubstringAfter(this String str, string delimiter)
        {
            return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
        }

        public static string SubstringBetween(this string str,string startdel,string enddel)
        {
            int indexstart = str.IndexOf(startdel);
            int indexend = str.IndexOf(enddel);
            return str.Substring(indexstart + 1, indexend - 1).Trim() ;
        }

        public static string Message(this string str)
        {
            int indexstart = str.IndexOf(":") +1;
            return str.Substring(indexstart).Trim();
        }

        public static string LogLevel(this string str)
        {
            return str.SubstringBetween("[", "]");
        }
    }
}
