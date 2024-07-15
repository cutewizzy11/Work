using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;
using System;

namespace Jurilinka
{
    public partial class ApproveLawyersForm : Form
    {
        private readonly DatabaseContext _context;

        public ApproveLawyersForm()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            LoadLawyerRequests();
        }

        private void LoadLawyerRequests()
        {
            var pendingLawyers = _context.Lawyers.Find(l => l.IsApproved == false).ToList();
            lawyerRequestsListBox.Items.Clear();
            foreach (var lawyer in pendingLawyers)
            {
                // Display relevant information including License Number
                lawyerRequestsListBox.Items.Add($"{lawyer.Id} - {lawyer.FirstName} {lawyer.LastName} - License: {lawyer.LicenseNumber}");
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lawyerRequestsListBox.SelectedItem != null)
            {
                var selectedLawyerId = lawyerRequestsListBox.SelectedItem.ToString().Split('-')[0].Trim();
                var filter = Builders<Lawyer>.Filter.Eq("_id", ObjectId.Parse(selectedLawyerId));
                var update = Builders<Lawyer>.Update.Set("IsApproved", true);
                _context.Lawyers.UpdateOne(filter, update);

                MessageBox.Show("Lawyer approved successfully!");
                LoadLawyerRequests();
            }
            else
            {
                MessageBox.Show("Please select a lawyer to approve.");
            }
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            if (lawyerRequestsListBox.SelectedItem != null)
            {
                var selectedLawyerId = lawyerRequestsListBox.SelectedItem.ToString().Split('-')[0].Trim();
                var filter = Builders<Lawyer>.Filter.Eq("_id", ObjectId.Parse(selectedLawyerId));
                _context.Lawyers.DeleteOne(filter);

                MessageBox.Show("Lawyer disapproved and removed successfully!");
                LoadLawyerRequests();
            }
            else
            {
                MessageBox.Show("Please select a lawyer to disapprove.");
            }
        }
    }
}
