namespace Jurilinka
{
    partial class AdminDashboardForm
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
            this.btnPushNotifications = new System.Windows.Forms.Button();
            this.btnLegalDatabases = new System.Windows.Forms.Button();
            this.btnHandlePayments = new System.Windows.Forms.Button();
            this.btnChangeStyle = new System.Windows.Forms.Button();
            this.btnApproveLawyers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPushNotifications
            // 
            this.btnPushNotifications.Location = new System.Drawing.Point(50, 50);
            this.btnPushNotifications.Name = "btnPushNotifications";
            this.btnPushNotifications.Size = new System.Drawing.Size(200, 30);
            this.btnPushNotifications.TabIndex = 0;
            this.btnPushNotifications.Text = "Push Notifications";
            this.btnPushNotifications.UseVisualStyleBackColor = true;
            this.btnPushNotifications.Click += new System.EventHandler(this.btnPushNotifications_Click);
            // 
            // btnLegalDatabases
            // 
            this.btnLegalDatabases.Location = new System.Drawing.Point(50, 100);
            this.btnLegalDatabases.Name = "btnLegalDatabases";
            this.btnLegalDatabases.Size = new System.Drawing.Size(200, 30);
            this.btnLegalDatabases.TabIndex = 1;
            this.btnLegalDatabases.Text = "Manage Legal Databases";
            this.btnLegalDatabases.UseVisualStyleBackColor = true;
            this.btnLegalDatabases.Click += new System.EventHandler(this.btnLegalDatabases_Click);
            // 
            // btnHandlePayments
            // 
            this.btnHandlePayments.Location = new System.Drawing.Point(50, 150);
            this.btnHandlePayments.Name = "btnHandlePayments";
            this.btnHandlePayments.Size = new System.Drawing.Size(200, 30);
            this.btnHandlePayments.TabIndex = 2;
            this.btnHandlePayments.Text = "Handle Payments";
            this.btnHandlePayments.UseVisualStyleBackColor = true;
            this.btnHandlePayments.Click += new System.EventHandler(this.btnHandlePayments_Click);
            // 
            // btnChangeStyle
            // 
            this.btnChangeStyle.Location = new System.Drawing.Point(50, 200);
            this.btnChangeStyle.Name = "btnChangeStyle";
            this.btnChangeStyle.Size = new System.Drawing.Size(200, 30);
            this.btnChangeStyle.TabIndex = 3;
            this.btnChangeStyle.Text = "Change App Style";
            this.btnChangeStyle.UseVisualStyleBackColor = true;
            this.btnChangeStyle.Click += new System.EventHandler(this.btnChangeStyle_Click);
            // 
            // btnApproveLawyers
            // 
            this.btnApproveLawyers.Location = new System.Drawing.Point(50, 250);
            this.btnApproveLawyers.Name = "btnApproveLawyers";
            this.btnApproveLawyers.Size = new System.Drawing.Size(200, 30);
            this.btnApproveLawyers.TabIndex = 4;
            this.btnApproveLawyers.Text = "Approve Lawyers";
            this.btnApproveLawyers.UseVisualStyleBackColor = true;
            this.btnApproveLawyers.Click += new System.EventHandler(this.btnApproveLawyers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnApproveLawyers);
            this.Controls.Add(this.btnChangeStyle);
            this.Controls.Add(this.btnHandlePayments);
            this.Controls.Add(this.btnLegalDatabases);
            this.Controls.Add(this.btnPushNotifications);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnPushNotifications;
        private System.Windows.Forms.Button btnLegalDatabases;
        private System.Windows.Forms.Button btnHandlePayments;
        private System.Windows.Forms.Button btnChangeStyle;
        private System.Windows.Forms.Button btnApproveLawyers;
        private System.Windows.Forms.Button btnLogout;
    }
}
