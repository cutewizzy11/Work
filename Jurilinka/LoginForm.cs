using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurilinka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterSelectionForm registerSelectionForm = new RegisterSelectionForm();
            registerSelectionForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new DatabaseContext();
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var client = context.Clients.Find(c => c.Email == email && c.Password == password).FirstOrDefault();
            var lawyer = context.Lawyers.Find(l => l.Email == email && l.Password == password).FirstOrDefault();
            var admin = context.Admins.Find(a => a.Email == email && a.Password == password).FirstOrDefault();

            if (client != null)
            {
                MessageBox.Show("Client logged in successfully!");
                ClientDashboard clientDashboard = new ClientDashboard();
                clientDashboard.Show();
                this.Hide();
            }
            else if (lawyer != null)
            {
                MessageBox.Show("Lawyer logged in successfully!");
                LawyerDashboard lawyerDashboard = new LawyerDashboard();
                lawyerDashboard.Show();
                this.Hide();
            }
            else if (admin != null)
            {
                MessageBox.Show("Welcome Paul!");
                AdminDashboardForm adminDashboard = new AdminDashboardForm();
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
