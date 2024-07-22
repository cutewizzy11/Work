namespace Jurilinka
{
    partial class LawyerDashboard
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
            this.btnProfileSetup = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnClientInfo = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnLegalResources = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfileSetup
            // 
            this.btnProfileSetup.Location = new System.Drawing.Point(50, 30);
            this.btnProfileSetup.Name = "btnProfileSetup";
            this.btnProfileSetup.Size = new System.Drawing.Size(200, 30);
            this.btnProfileSetup.TabIndex = 0;
            this.btnProfileSetup.Text = "Profile Setup";
            this.btnProfileSetup.UseVisualStyleBackColor = true;
            this.btnProfileSetup.Click += new System.EventHandler(this.btnProfileSetup_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(50, 70);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(200, 30);
            this.btnNotifications.TabIndex = 1;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnClientInfo
            // 
            this.btnClientInfo.Location = new System.Drawing.Point(50, 110);
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.Size = new System.Drawing.Size(200, 30);
            this.btnClientInfo.TabIndex = 2;
            this.btnClientInfo.Text = "Client Info & Cases";
            this.btnClientInfo.UseVisualStyleBackColor = true;
            this.btnClientInfo.Click += new System.EventHandler(this.btnClientInfo_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(50, 150);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(200, 30);
            this.btnBilling.TabIndex = 3;
            this.btnBilling.Text = "Billing & Payments";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(50, 190);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(200, 30);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnAvailability
            // 
            this.btnAvailability.Location = new System.Drawing.Point(50, 230);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(200, 30);
            this.btnAvailability.TabIndex = 5;
            this.btnAvailability.Text = "Update Availability";
            this.btnAvailability.UseVisualStyleBackColor = true;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(50, 270);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(200, 30);
            this.btnDocuments.TabIndex = 6;
            this.btnDocuments.Text = "Document Sharing";
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnLegalResources
            // 
            this.btnLegalResources.Location = new System.Drawing.Point(50, 310);
            this.btnLegalResources.Name = "btnLegalResources";
            this.btnLegalResources.Size = new System.Drawing.Size(200, 30);
            this.btnLegalResources.TabIndex = 7;
            this.btnLegalResources.Text = "Legal Resources";
            this.btnLegalResources.UseVisualStyleBackColor = true;
            this.btnLegalResources.Click += new System.EventHandler(this.btnLegalResources_Click);
            // 
            // LawyerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 370);
            this.Controls.Add(this.btnLegalResources);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnClientInfo);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnProfileSetup);
            this.Name = "LawyerDashboardForm";
            this.Text = "Lawyer Dashboard";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnProfileSetup;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnClientInfo;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnLegalResources;
    }
}
