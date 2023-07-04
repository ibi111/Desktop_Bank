using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Withdraw : Form
    {
        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int account) && int.TryParse(textBox2.Text, out int amount))
            {
                // Check for empty fields
                if (account == 0 || amount == 0)
                {
                    MessageBox.Show("Please enter valid account number and amount.");
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the account has sufficient balance for withdrawal
                        string balanceCheckQuery = "SELECT AccountBalance FROM Accounts WHERE AccountNo = @AccountNo";
                        using (SqlCommand balanceCheckCommand = new SqlCommand(balanceCheckQuery, connection))
                        {
                            balanceCheckCommand.Parameters.AddWithValue("@AccountNo", account);

                            object result = balanceCheckCommand.ExecuteScalar();
                            decimal currentBalance = Convert.ToDecimal(result);

                            if (currentBalance < amount)
                            {
                                MessageBox.Show("Insufficient balance. Cannot withdraw the specified amount.");
                                return;
                            }
                        }

                        // Update the AccountBalance in the Accounts table
                        string updateQuery = "UPDATE Accounts SET AccountBalance = AccountBalance - @Amount WHERE AccountNo = @AccountNo";

                        // Insert the transaction record in the Transactions table
                        string insertQuery = "INSERT INTO Transactions (AccountNo, ActionType, AmountChanged) VALUES (@AccountNo, @ActionType, @AmountChanged)";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            // Set parameters for the update query
                            updateCommand.Parameters.AddWithValue("@Amount", amount);
                            updateCommand.Parameters.AddWithValue("@AccountNo", account);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Set parameters for the insert query
                                insertCommand.Parameters.AddWithValue("@AccountNo", account);
                                insertCommand.Parameters.AddWithValue("@ActionType", "Withdrawal");
                                insertCommand.Parameters.AddWithValue("@AmountChanged", "-" + amount.ToString());

                                // Execute the insert query
                                insertCommand.ExecuteNonQuery();

                                MessageBox.Show("Amount withdrawn successfully. Transaction recorded.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to withdraw amount. Account not found.");
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
                MessageBox.Show("Please enter valid integer values for account number and amount.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard d = new dashboard();
            d.Show();
        }
    }
}
