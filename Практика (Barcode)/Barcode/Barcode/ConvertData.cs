using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class ConvertData
    {
        static public int[] ConvertFromStringToIntArray(string str)
        {
            return str.Select(x => int.Parse(x.ToString())).ToArray();
        }
    }
}
