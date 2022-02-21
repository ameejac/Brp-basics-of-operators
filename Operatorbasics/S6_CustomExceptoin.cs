using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorbasics
{
    public class S6_CustomException : Exception
    {
        public enum UserException
        {
            INVALID_DATA, 
            INVALID_VALUE
        }
        private readonly UserException Type;
        public S6_CustomException(UserException Type, string Message) : base(Message)
        {
            this.Type = Type;
        }
    }
}
