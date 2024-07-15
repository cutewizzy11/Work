namespace Jurilinka
{
    partial class PushNotificationsForm
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
            this.txtNotificationMessage = new System.Windows.Forms.TextBox();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNotificationMessage
            // 
            this.txtNotificationMessage.Location = new System.Drawing.Point(12, 12);
            this.txtNotificationMessage.Multiline = true;
            this.txtNotificationMessage.Name = "txtNotificationMessage";
            this.txtNotificationMessage.Size = new System.Drawing.Size(260, 100);
            this.txtNotificationMessage.TabIndex = 0;
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Location = new System.Drawing.Point(12, 118);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(260, 30);
            this.btnSendNotification.TabIndex = 1;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // PushNotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.txtNotificationMessage);
            this.Name = "PushNotificationsForm";
            this.Text = "Push Notifications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNotificationMessage;
        private System.Windows.Forms.Button btnSendNotification;
    }
}
