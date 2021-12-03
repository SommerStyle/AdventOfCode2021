using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Parsers
{
    public class FileParser
    {
        public static int[] ReadAsIntArray(String path)
        {
            return File.ReadAllLines(path)
                .Select(s => Convert.ToInt32(s))
                .ToArray();
        }

        public static String[] ReadAsStringArray(String path)
        {
            return File.ReadAllLines(path).ToArray();
        }
    }
}
