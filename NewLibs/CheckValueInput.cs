using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibs
{
    public class CheckValueInput
    {
        public static bool CheckIsInt(string inputValue)
        {
            int result;
            return int.TryParse(inputValue, out result);
        }

        public static bool CheckIsFloat(string inputValue)
        {
            float result;
            return float.TryParse(inputValue, out result);
        }
    }
}
