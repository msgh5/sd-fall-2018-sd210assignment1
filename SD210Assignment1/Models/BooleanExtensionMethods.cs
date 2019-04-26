using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD210Assignment1.Models
{
    public static class BooleanExtensionMethods
    {
        public static string ToYesOrNo(this bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}