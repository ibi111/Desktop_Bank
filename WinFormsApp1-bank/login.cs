
using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WinFormsApp1_bank
{
    public partial class login : Form
    {

        private string connectionString = "Data Source=DESKTOP-J9T93IU\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();
                        int count = Convert.ToInt32(result);


                        if (count > 0)
                        {
                            //MessageBox.Show("Login Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Perform any additional actions or navigate to another form
                            connection.Close();

                            if (IsAdminUser(username, password))
                            {
                                this.Hide();
                                AdminDashboard dashForm = new AdminDashboard();
                                dashForm.Show();
                            }
                            else
                            {
                                this.Hide();
                                dashboard dashForm = new dashboard();
                                dashForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                            connection.Close();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool IsAdminUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password AND IsAdmin = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
