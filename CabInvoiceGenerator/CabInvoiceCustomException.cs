using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceCustomException:Exception
    {
        public ExceptionType exceptionType;
        public CabInvoiceCustomException(ExceptionType exceptiontype,string message):base(message) 
        {
            this.exceptionType = exceptiontype;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDER,
            INVALID_USER_ID,
            INVALID_RIDE_TYPE
        }
    }
}
