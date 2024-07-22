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
    public partial class LawyerDashboard : Form
    {
        public LawyerDashboard()
        {
            InitializeComponent();
        }
        private void btnProfileSetup_Click(object sender, EventArgs e)
        {
            // Open a form for profile setup
            ProfileSetupForm profileSetupForm = new ProfileSetupForm();
            profileSetupForm.ShowDialog();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            // Open a form for notifications
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            // Open a form for client information and case details
            ClientInfoForm clientInfoForm = new ClientInfoForm();
            clientInfoForm.ShowDialog();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            // Open a form for billing and payments
            BillingForm billingForm = new BillingForm();
            billingForm.ShowDialog();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            // Open a form for calendar
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            // Open a form to update availability
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.ShowDialog();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            // Open a form for document sharing and e-signature capabilities
            DocumentsForm documentsForm = new DocumentsForm();
            documentsForm.ShowDialog();
        }

        private void btnLegalResources_Click(object sender, EventArgs e)
        {
            // Open a form for legal resources
            LegalResourcesForm legalResourcesForm = new LegalResourcesForm();
            legalResourcesForm.ShowDialog();
        }
    }
}
