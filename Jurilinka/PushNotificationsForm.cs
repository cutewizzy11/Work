using System;
using System.Windows.Forms;

namespace Jurilinka
{
    public partial class PushNotificationsForm : Form
    {
        public PushNotificationsForm()
        {
            InitializeComponent();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            string message = txtNotificationMessage.Text;
            // Logic to send notification to users
            MessageBox.Show("Notification sent!");
        }
    }
}
