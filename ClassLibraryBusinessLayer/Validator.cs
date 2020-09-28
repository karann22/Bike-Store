using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryBusinessLayer.Bus
{
    public class Validator
    {
        public static bool Is12Digit(string value)
        {
            if (!Regex.IsMatch(value, @"^\d{12}$"))
                return false;
            return true;
        }
        public static bool IsEmpty(string value)
        {
            if (Regex.IsMatch(value, @"^\s*$"))
                return false;
            return true;
        }
        public static bool IsAlphabetNumber(string value)
        {
            if (Regex.IsMatch(value, @"^([a-zA-Z|\s]+)$"))
                return true;
            return false;
        }
        public static bool IsDecimal(string value)
        {
            if (Regex.IsMatch(value, @"^(([0-9]+)\.([0-9]+))$"))
                return true;
            return false;
        }
    }
}
