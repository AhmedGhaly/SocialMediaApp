using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string msg): base(msg)
        {
            
        }
    }
}
