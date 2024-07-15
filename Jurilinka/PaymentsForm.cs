using System;
using System.Windows.Forms;

namespace Jurilinka
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void btnAddPaystackKeys_Click(object sender, EventArgs e)
        {
            string publicKey = txtPublicKey.Text;
            string secretKey = txtSecretKey.Text;
            // Logic to save Paystack API keys
            MessageBox.Show("Paystack keys added!");
        }
        private void TxtPublicKey_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtPublicKey_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter Public Key";
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtSecretKey_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtSecretKey_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter Secret Key";
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
