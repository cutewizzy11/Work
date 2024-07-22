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
    public partial class ProfileSetupForm : Form
    {
        public ProfileSetupForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the profile information logic
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string licenseNumber = txtLicenseNumber.Text;

            // Example save logic (replace with actual save logic)
            MessageBox.Show($"Profile saved:\nFirst Name: {firstName}\nLast Name: {lastName}\nLicense Number: {licenseNumber}", "Profile Saved");
        }
    }
}
