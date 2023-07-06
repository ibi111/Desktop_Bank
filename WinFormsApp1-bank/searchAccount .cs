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
    public partial class searchAccount : Form
    {
        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public searchAccount()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard d = new dashboard();
            d.Show();
        }

        private void label1_Click(object sender, EventArgs e)
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

            int accountNo;
            if (!int.TryParse(textBox2.Text, out accountNo))
            {
                MessageBox.Show("Invalid account number. Please enter a valid integer.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Accounts WHERE AccountNo = @AccountNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AccountNo", accountNo);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Read the values from the reader
                        int accountNumber = (int)reader["AccountNo"];
                        decimal accountBalance = (decimal)reader["AccountBalance"];
                        string holderName = (string)reader["HolderName"];
                        decimal loanAmount = (decimal)reader["LoanAmount"];
                        string creditCardType = (string)reader["CreditCardType"];

                        // Display the account details to the user
                        string message = $"Account No: {accountNumber}\n" +
                                         $"Holder Name: {holderName}\n" +
                                         $"Account Balance: {accountBalance:C2}\n" +
                                         $"Loan Amount: {loanAmount:C2}\n" +
                                         $"Credit Card Type: {creditCardType}";

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("Account not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving account details: " + ex.Message);
                }
            }

        }
    }
}
