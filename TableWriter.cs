using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableWritingMethods
{
    class TableWriter
    {
        public static string AddBlanks(string data, int max)
        {
            for(int i = data.Length; i < max; i++) { data += " "; }
            return data;
        }

        public static void WriteArrays(string[][] arrays)
        {
            var max = 0;
            arrays.ToList().ForEach(x => x.ToList().ForEach(y => { if (y.Length > max) max = y.Length; }));
            foreach(var array in arrays) {
                foreach (var data in array){
                    Console.Write(AddBlanks(data, max));
                } Console.WriteLine(""); }
        }
        /// <summary>
        /// Make sure your object's .ToString() is formatted how you want it printed.
        /// Suggested to add a .GetColumnNames() method and printing prior
        /// </summary>
        /// <param name="objs"></param>
        public static void WriteTable(Object[] objs)
        {
            objs.ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
        
    }
}
