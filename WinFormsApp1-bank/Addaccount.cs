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
    public partial class Addaccount : Form
    {

        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Addaccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int accountNo = 0;
            decimal loan = 0;
            decimal balance = 0;
            string creditType = textBox5.Text;

            // Check for empty fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(creditType))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            // Parse and validate the input for accountNo
            if (!int.TryParse(textBox2.Text, out accountNo))
            {
                MessageBox.Show("Invalid Account Number. Please enter a valid integer value.");
                return;
            }

            // Parse and validate the input for loan
            if (!decimal.TryParse(textBox3.Text, out loan))
            {
                MessageBox.Show("Invalid Loan Amount. Please enter a valid decimal value.");
                return;
            }

            // Parse and validate the input for balance
            if (!decimal.TryParse(textBox4.Text, out balance))
            {
                MessageBox.Show("Invalid Account Balance. Please enter a valid decimal value.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Accounts (AccountNo, AccountBalance, HolderName, LoanAmount, CreditCardType) " +
                                   "VALUES (@AccountNo, @AccountBalance, @HolderName, @LoanAmount, @CreditCardType)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNo", accountNo);
                        command.Parameters.AddWithValue("@AccountBalance", balance);
                        command.Parameters.AddWithValue("@HolderName", name);
                        command.Parameters.AddWithValue("@LoanAmount", loan);
                        command.Parameters.AddWithValue("@CreditCardType", creditType);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert record.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addaccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
