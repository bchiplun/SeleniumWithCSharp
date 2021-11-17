using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCsharp.CustomExcetption
{
    class ButtonNotEnabled : Exception
    {
        public ButtonNotEnabled(string msg) : base(msg)
        {

        }
    }
}
