using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Repository.Repositories
{
    class Functions
    {
       public static String GetConnectionString()
       {
           return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
       }


    }
}
