using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Jurilinka
{
    public partial class LawyerRegisterForm : Form
    {
        private readonly DatabaseContext _context;

        public LawyerRegisterForm()
        {
            InitializeComponent();
            _context = new DatabaseContext();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any required fields are empty
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Check if the email is already registered
                if (_context.IsEmailAlreadyRegistered(txtEmail.Text))
                {
                    MessageBox.Show("This email is already registered. Please use a different email.");
                    return;
                }

                // Check if the license number is already used
                if (_context.IsLicenseNumberAlreadyUsed(txtLicenseNumber.Text))
                {
                    MessageBox.Show("This license number is already used. Please use a different license number.");
                    return;
                }

                var lawyer = new Lawyer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    LicenseNumber = txtLicenseNumber.Text.ToUpper(),
                    Email = txtEmail.Text.ToLower(),
                    Password = txtPassword.Text,
                    IsApproved = false
                };
                _context.Lawyers.InsertOne(lawyer);

                MessageBox.Show("Lawyer registered successfully! Waiting for admin approval.");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering lawyer: " + ex.Message);
            }
        }
    }
}
