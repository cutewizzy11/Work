namespace Jurilinka
{
    partial class ApproveLawyersForm
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
            this.lawyerRequestsListBox = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDisapprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lawyerRequestsListBox
            // 
            this.lawyerRequestsListBox.FormattingEnabled = true;
            this.lawyerRequestsListBox.Location = new System.Drawing.Point(12, 7);
            this.lawyerRequestsListBox.Name = "lawyerRequestsListBox";
            this.lawyerRequestsListBox.Size = new System.Drawing.Size(443, 277);
            this.lawyerRequestsListBox.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(101, 303);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(120, 30);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDisapprove
            // 
            this.btnDisapprove.Location = new System.Drawing.Point(241, 303);
            this.btnDisapprove.Name = "btnDisapprove";
            this.btnDisapprove.Size = new System.Drawing.Size(120, 30);
            this.btnDisapprove.TabIndex = 2;
            this.btnDisapprove.Text = "Disapprove";
            this.btnDisapprove.UseVisualStyleBackColor = true;
            this.btnDisapprove.Click += new System.EventHandler(this.btnDisapprove_Click);
            // 
            // ApproveLawyersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 354);
            this.Controls.Add(this.btnDisapprove);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lawyerRequestsListBox);
            this.Name = "ApproveLawyersForm";
            this.Text = "Approve Lawyers";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lawyerRequestsListBox;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDisapprove;
    }
}
