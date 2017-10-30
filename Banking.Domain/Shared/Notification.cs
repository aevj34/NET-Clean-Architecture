using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Shared
{
    public class Notification
    {

        private List<Error> errors = new List<Error>();

        public void addError(String message)
        {
            this.addError(message, null);
        }

        public void addError(String message, Exception e)
        {
            errors.Add(new Error(message, e));
        }

        public String errorMessage() 
        {
          return String.Join(", ", errors);
         }
         
        public bool hasErrors()
        {
            return errors.Count>0;
        }
    }
}
