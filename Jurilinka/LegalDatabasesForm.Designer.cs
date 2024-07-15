namespace Jurilinka
{
    partial class LegalDatabasesForm
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
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.btnAddApi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(12, 12);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(260, 20);
            this.txtApiUrl.TabIndex = 0;
            // 
            // btnAddApi
            // 
            this.btnAddApi.Location = new System.Drawing.Point(12, 38);
            this.btnAddApi.Name = "btnAddApi";
            this.btnAddApi.Size = new System.Drawing.Size(260, 30);
            this.btnAddApi.TabIndex = 1;
            this.btnAddApi.Text = "Add API";
            this.btnAddApi.UseVisualStyleBackColor = true;
            this.btnAddApi.Click += new System.EventHandler(this.btnAddApi_Click);
            // 
            // LegalDatabasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnAddApi);
            this.Controls.Add(this.txtApiUrl);
            this.Name = "LegalDatabasesForm";
            this.Text = "Legal Databases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Button btnAddApi;
    }
}
