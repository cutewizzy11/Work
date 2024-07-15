using System;
using System.Windows.Forms;

namespace Jurilinka
{
    public partial class LegalDatabasesForm : Form
    {
        public LegalDatabasesForm()
        {
            InitializeComponent();
        }

        private void btnAddApi_Click(object sender, EventArgs e)
        {
            string apiUrl = txtApiUrl.Text;
            // Logic to add API for legal resources
            MessageBox.Show("Legal resource API added!");
        }
    }
}
