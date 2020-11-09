using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Barcode
{
    class BarcodeOperations
    {
        static public bool IsVerify(int[] barcode)
        {
            int dimensionTwo = 0, dimensionThree = 0;
            for (int i = 0; i < barcode.Length; i++)
            {
                if (i % 2 != 0)
                    dimensionTwo += barcode[i];
                else
                    dimensionThree += barcode[i];
            }
            dimensionThree -= barcode[barcode.Length - 1];
            int result = 10 - (((dimensionTwo * 3) + dimensionThree) % 10);

            if (result == barcode[barcode.Length - 1]) return true;
            return false;
        }
    }
}
