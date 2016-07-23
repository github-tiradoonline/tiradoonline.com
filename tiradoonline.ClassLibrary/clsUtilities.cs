using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiradoonline.ClassLibrary
{
    public static class clsUtilities
    {
        public static bool isPhoneNumber(string phone)
        {
            string result = string.Empty;

            // loop through all characters and filter out only the numbers.
            for (int x = 0; x < phone.Length; x++)
            {
                if (char.IsDigit(Convert.ToChar(phone.Substring(x, 1))))
                {
                    result += phone.Substring(x, 1);
                }
            }

            if (result.Length >= 10)
                return true;
            else
                return false;
        }

        public static string FormatPhoneNumber(string phone)
        {
            string result = string.Empty;

            // loop through all characters and filter out only the numbers.
            for (int x = 0; x < phone.Length; x++)
            {
                if (char.IsDigit(Convert.ToChar(phone.Substring(x, 1))))
                {
                    result += phone.Substring(x, 1);
                }
            }

            // BEING FORMATTING THE PHONE NUMBER IN THE FORMAT (999) 999-9999 x3005
            if (result.Length > 0)
            {
                //REMOVE IF THE PHONE NUMBER BEGINS WITH A ONE.  E.G. 12013475555
                if (result[0].ToString() == "1")
                {
                    result = result.Substring(1, (result.Length - 1));
                }

                // START FORMATING AND CHECK IF PHONE IS > 10. IT SHOULD ONLY BE 9 DIGITS OR ELSE IT HAS AN EXTENSION.
                if (result.Length < 10)
                    return result;
                else
                {
                    if (result.Length == 10)
                        result = string.Format("({0}) {1}-{2}", result.Substring(0, 3), result.Substring(3, 3), result.Substring(6, 4));
                    else
                        result = string.Format("({0}) {1}-{2} x{3}", result.Substring(0, 3), result.Substring(3, 3), result.Substring(6, 4), result.Substring(10, result.Length - 10));

                    string e = string.Empty;
                }
            }

            return result;
        }
    }
}
