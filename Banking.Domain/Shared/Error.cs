using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Shared
{
    public class Error
    {
        private String message;
        private Exception cause;

        public Error(String message, Exception cause)
        {
            this.message = message;
            this.cause = cause;
        }

        public String getMessage()
        {
            return message;
        }

        public void setMessage(String message)
        {
            this.message = message;
        }

        public Exception getCause()
        {
            return cause;
        }

        public void setCause(Exception cause)
        {
            this.cause = cause;
        }
    }
}
