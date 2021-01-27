using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHard
{
    class IdNotFoundEx : Exception
    {
        public IdNotFoundEx(string message) : base(message)
        {
        }
    }
}
