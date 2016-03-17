using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WIFIGUIDemo.Helpers
{
    public class ConversionHelpers
    {
        public static int To12BitConversion(int value)
        {
            int result;

            if (value < 2048)
            {
                result = value;
            }
            else
            {
                result = ~(value);
                result++;
                result &= 0xFFF;
                result = -result;
            }

            return result;
        }
        public static int To16BitConversion(int value)
        {
            int result;

            if (value < 32768)
            {
                result = value;
            }
            else
            {
                result = ~(value);
                result++;
                result &= 0xFFFF;
                result = -result;
            }

            return result;
        }
    }
}
