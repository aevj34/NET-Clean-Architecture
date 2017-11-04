using Banking.Domain.Repositories;
using Banking.Domain.Model;
using System;
using System.Data.SqlClient;
using System.Data;

// ReSharper disable once CheckNamespace
namespace Banking.Repository.Repositories
{
    public class BankAccountRepositoryAdoNet:IBankAccountRepository
    {
        public BankAccount FindByNumber2(string accountNumber)
        {
            var bankAccount = new BankAccount();            
            const string cmdText = "SELECT [Bank_Account_Id],[number], [balance],[locked],[Customer_Id] FROM Bank_Account WHERE number = @account_number";
            using (var con = new SqlConnection(Functions.GetConnectionString()))
            {
                var command = new SqlCommand(cmdText, con) { CommandType = CommandType.Text };
                command.Parameters.AddRange(new[]
                {
                    new SqlParameter
                    {
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        ParameterName = "@account_number",
                        Value = accountNumber
                    }
                });
                con.Open();

                using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        bankAccount.setId(reader.GetInt64(reader.GetOrdinal("Bank_Account_Id")));
                        bankAccount.setNumber(reader.GetString(reader.GetOrdinal("number")));
                        bankAccount.setBalance(reader.GetDecimal(reader.GetOrdinal("balance")));
                        bankAccount.setIsLocked(reader.GetBoolean(reader.GetOrdinal("locked")));                       
                    }
                }
            }
            return bankAccount;            
        }

        public BankAccount FindByNumber(string accountNumber)
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

        public BankAccount FindByNumberLocked(string accountNumber)
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
