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
    public partial class DeleteAccount : Form
    {
        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard d = new AdminDashboard();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int accountNo;
            if (!int.TryParse(textBox2.Text, out accountNo))
            {
                MessageBox.Show("Invalid account number. Please enter a valid integer.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM Accounts WHERE AccountNo = @AccountNo";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@AccountNo", accountNo);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Account not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the account: " + ex.Message);
                    }
                }
            }
        }
    }
}
