using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Goodson
{
    class Validator
    {

        public static bool IsDouble(string userRadius)
        {
            return double.TryParse(userRadius, out double radius);
        }
    }
}
