using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_uppgift3
{
    internal class NumberError : UserError
    {
        public override string UEMessage()
        {
            return "Lorem ipsum or something. Number.";
        }
    }
}
