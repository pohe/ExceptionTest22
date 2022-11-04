using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest22
{
    public class NotInRangeException : Exception
    {
        public NotInRangeException():base()
        {

        }

        public NotInRangeException(string message): base(message)
        {

        }
    }
}
