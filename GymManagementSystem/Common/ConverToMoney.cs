using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Common
{
    public class ConverToMoney
    {
        public static string conver(string numberString)
        {
            string integerPart = "";
            string decimalPart = "";
            if (numberString.Contains("."))
            {
                int dotIndex = numberString.IndexOf('.');

                integerPart = numberString.Substring(0, dotIndex);
                decimalPart = numberString.Substring(dotIndex);
            }
            else
            {
                integerPart = numberString;
            }

            string result = (double.Parse(integerPart)).ToString("N0") + decimalPart;
            return result;
        }
    }
}
