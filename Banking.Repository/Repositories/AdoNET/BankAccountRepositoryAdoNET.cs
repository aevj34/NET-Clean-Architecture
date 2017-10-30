using Banking.Domain.Repositories;
using Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Banking.Repository.Repositories
{
    public class BankAccountRepositoryAdoNET:IBankAccountRepository
    {

        public BankAccount findByNumber(string accountNumber)
        {
            SqlConnection conn = new SqlConnection(Functions.GetConnectionString());
            String query = "SELECT [Bank_Account_Id],[number], [balance],[locked],[Customer_Id] FROM Bank_Account WHERE number = '" + accountNumber + "'";

            SqlCommand command = new SqlCommand(query, conn);
            command.Connection.Open();
            SqlDataReader reader;
            reader = command.ExecuteReader();

            BankAccount bankAccount = new BankAccount();

            if (reader.Read())
            {      
                bankAccount.setId(reader.GetInt64(reader.GetOrdinal("Bank_Account_Id")));
                bankAccount.setNumber(reader.GetString(reader.GetOrdinal("number")));
                bankAccount.setBalance(reader.GetDecimal(reader.GetOrdinal("balance")));
                bankAccount.setIsLocked(reader.GetBoolean(reader.GetOrdinal("locked")));
            }

            command.Connection.Close();
            conn.Dispose();
            conn.Close();

            return bankAccount;

        }

        public BankAccount findByNumberLocked(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public void save(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void update(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void merge(BankAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
