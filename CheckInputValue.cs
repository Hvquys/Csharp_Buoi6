using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_buoi6
{
    public class CheckInputValue
    {
        public bool CheckIsInt(string inputValue)
        {
            int result;
            return int.TryParse(inputValue, out result);
        }

        public bool CheckIsFloat(string inputValue)
        {
            float result;
            return float.TryParse(inputValue, out result);
        }
    }
}
