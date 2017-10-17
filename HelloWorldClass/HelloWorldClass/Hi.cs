using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldClass
{
    public class Hi
    {
        public string result(string input)
        {
            if (input == "HELLO")
                return "WORLD";
            return "INVALID";
        }

    }
}
