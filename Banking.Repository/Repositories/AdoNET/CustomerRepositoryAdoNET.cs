using Banking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Repository.Repositories
{
    public class CustomerRepositoryAdoNET:ICustomerRepository
    {
        public void save(Domain.Model.Customer entity)
        {
            throw new NotImplementedException();
        }

        public void update(Domain.Model.Customer entity)
        {
            throw new NotImplementedException();
        }

        public void merge(Domain.Model.Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
