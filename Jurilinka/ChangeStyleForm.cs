using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jurilinka
{
    public partial class ChangeStyleForm : Form
    {
        public ChangeStyleForm()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Logic to change the app's background color
                MessageBox.Show("App background color changed!");
            }
        }
    }
}
