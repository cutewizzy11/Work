using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jurilinka
{
    public partial class ClientRegisterForm : Form
    {
        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Client
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                var context = new DatabaseContext();
                context.Clients.InsertOne(client);

                MessageBox.Show("Client registered successfully!");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering client: " + ex.Message);
            }
        }
    }
}

public class Client
{
    public ObjectId Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}