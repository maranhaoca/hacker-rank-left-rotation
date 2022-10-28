using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'rotateLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            List<int> rotateArr = new List<int>();

            rotateArr.AddRange(arr.GetRange(d, arr.Count - d));
            rotateArr.AddRange(arr.GetRange(0, d));

            return rotateArr;
        }
    }
}