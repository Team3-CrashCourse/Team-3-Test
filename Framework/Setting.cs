using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_3_Test.Framework
{
    public static class Setting
    {
        public const string Url = "http://52.177.12.77:8080/uk/";
        public static readonly TimeSpan ImplicitWait = TimeSpan.FromMilliseconds(Convert.ToInt32("3000"));
    }
}
