namespace Jurilinka
{
    partial class PaymentsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.btnAddPaystackKeys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(12, 12);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(260, 20);
            this.txtPublicKey.TabIndex = 0;
            this.txtPublicKey.Text = "Enter Public Key";
            this.txtPublicKey.ForeColor = System.Drawing.Color.Gray;
            this.txtPublicKey.GotFocus += TxtPublicKey_GotFocus;
            this.txtPublicKey.LostFocus += TxtPublicKey_LostFocus;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(12, 38);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(260, 20);
            this.txtSecretKey.TabIndex = 1;
            this.txtSecretKey.Text = "Enter Secret Key";
            this.txtSecretKey.ForeColor = System.Drawing.Color.Gray;
            this.txtSecretKey.GotFocus += TxtSecretKey_GotFocus;
            this.txtSecretKey.LostFocus += TxtSecretKey_LostFocus;
            // 
            // btnAddPaystackKeys
            // 
            this.btnAddPaystackKeys.Location = new System.Drawing.Point(12, 64);
            this.btnAddPaystackKeys.Name = "btnAddPaystackKeys";
            this.btnAddPaystackKeys.Size = new System.Drawing.Size(260, 30);
            this.btnAddPaystackKeys.TabIndex = 2;
            this.btnAddPaystackKeys.Text = "Add Paystack Keys";
            this.btnAddPaystackKeys.UseVisualStyleBackColor = true;
            this.btnAddPaystackKeys.Click += new System.EventHandler(this.btnAddPaystackKeys_Click);
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnAddPaystackKeys);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.txtPublicKey);
            this.Name = "PaymentsForm";
            this.Text = "Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Button btnAddPaystackKeys;
    }
}
