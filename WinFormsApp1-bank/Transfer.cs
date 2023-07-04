using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;


namespace WinFormsApp1_bank
{

    public partial class Transfer : Form
    {
        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Transfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int toAccount) &&
                int.TryParse(textBox3.Text, out int fromAccount) &&
                int.TryParse(textBox2.Text, out int money))
            {
                // Check for empty fields
                if (toAccount == 0 || fromAccount == 0 || money == 0)
                {
                    MessageBox.Show("Please enter valid account numbers and amount.");
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if both accounts exist
                        string accountCheckQuery = "SELECT COUNT(*) FROM Accounts WHERE AccountNo IN (@ToAccount, @FromAccount)";
                        using (SqlCommand accountCheckCommand = new SqlCommand(accountCheckQuery, connection))
                        {
                            accountCheckCommand.Parameters.AddWithValue("@ToAccount", toAccount);
                            accountCheckCommand.Parameters.AddWithValue("@FromAccount", fromAccount);

                            object result = accountCheckCommand.ExecuteScalar();
                            int count = Convert.ToInt32(result);

                            if (count != 2)
                            {
                                MessageBox.Show("One or both accounts do not exist.");
                                return;
                            }
                        }

                        // Check if the fromAccount has sufficient balance for the transfer
                        string balanceCheckQuery = "SELECT AccountBalance FROM Accounts WHERE AccountNo = @FromAccount";
                        using (SqlCommand balanceCheckCommand = new SqlCommand(balanceCheckQuery, connection))
                        {
                            balanceCheckCommand.Parameters.AddWithValue("@FromAccount", fromAccount);

                            object result = balanceCheckCommand.ExecuteScalar();
                            decimal currentBalance = Convert.ToDecimal(result);

                            if (currentBalance < money)
                            {
                                MessageBox.Show("Insufficient balance in the source account. Cannot transfer the specified amount.");
                                return;
                            }
                        }

                        // Update the AccountBalances in the Accounts table
                        string updateQuery = "UPDATE Accounts SET AccountBalance = " +
                            "CASE " +
                            "WHEN AccountNo = @ToAccount THEN AccountBalance + @Money " +
                            "WHEN AccountNo = @FromAccount THEN AccountBalance - @Money " +
                            "END " +
                            "WHERE AccountNo IN (@ToAccount, @FromAccount)";

                        // Insert the transaction record in the Transactions table
                        string insertQuery = "INSERT INTO Transactions (AccountNo, ActionType, AmountChanged) " +
                            "VALUES (@AccountNo, @ActionType, @AmountChanged)";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            // Set parameters for the update query
                            updateCommand.Parameters.AddWithValue("@ToAccount", toAccount);
                            updateCommand.Parameters.AddWithValue("@FromAccount", fromAccount);
                            updateCommand.Parameters.AddWithValue("@Money", money);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Set parameters for the insert query
                                insertCommand.Parameters.AddWithValue("@AccountNo", toAccount);
                                insertCommand.Parameters.AddWithValue("@ActionType", "->");
                                insertCommand.Parameters.AddWithValue("@AmountChanged", "+" + money.ToString());

                                // Execute the insert query
                                insertCommand.ExecuteNonQuery();

                                MessageBox.Show("Amount transferred successfully. Transaction recorded for the toAccount.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to transfer amount. Account not found.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for account numbers and amount.");
            }


        }
    }
}
