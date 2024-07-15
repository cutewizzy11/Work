using System;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Drawing;

namespace Jurilinka
{
    public partial class AdminDashboardForm : Form
    {
        private readonly DatabaseContext _context;

        public AdminDashboardForm()
        {
            InitializeComponent();
            _context = new DatabaseContext();
        }

        private void btnPushNotifications_Click(object sender, EventArgs e)
        {
            // Open a form to send push notifications
            PushNotificationsForm pushNotificationsForm = new PushNotificationsForm();
            pushNotificationsForm.ShowDialog();
        }

        private void btnLegalDatabases_Click(object sender, EventArgs e)
        {
            // Open a form to manage legal databases
            LegalDatabasesForm legalDatabasesForm = new LegalDatabasesForm();
            legalDatabasesForm.ShowDialog();
        }

        private void btnHandlePayments_Click(object sender, EventArgs e)
        {
            // Open a form to handle payments and view commissions
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.ShowDialog();
        }

        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            // Open a form to change the app's style
            ChangeStyleForm changeStyleForm = new ChangeStyleForm();
            changeStyleForm.ShowDialog();
        }

        private void btnApproveLawyers_Click(object sender, EventArgs e)
        {
            // Open a form to approve or disapprove lawyer registrations
            ApproveLawyersForm approveLawyersForm = new ApproveLawyersForm();
            approveLawyersForm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
