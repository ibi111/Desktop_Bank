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


namespace WinFormsApp1_bank
{
    public partial class Deposit : Form
    {
        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
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

                        // Update the AccountBalance in the Accounts table
                        string updateQuery = "UPDATE Accounts SET AccountBalance = AccountBalance + @Amount WHERE AccountNo = @AccountNo";

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
                                insertCommand.Parameters.AddWithValue("@ActionType", "Deposit");
                                insertCommand.Parameters.AddWithValue("@AmountChanged", "+" + amount.ToString());

                                // Execute the insert query
                                insertCommand.ExecuteNonQuery();

                                MessageBox.Show("Amount added successfully. Transaction recorded.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add amount. Account not found.");
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
