namespace Lab3
{
    partial class Lab03_Bai03
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
            this.buttonOpenServer = new System.Windows.Forms.Button();
            this.buttonOpenClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenServer
            // 
            this.buttonOpenServer.Location = new System.Drawing.Point(50, 50);
            this.buttonOpenServer.Name = "buttonOpenServer";
            this.buttonOpenServer.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenServer.TabIndex = 0;
            this.buttonOpenServer.Text = "Open Server Form";
            this.buttonOpenServer.UseVisualStyleBackColor = true;
            this.buttonOpenServer.Click += new System.EventHandler(this.buttonOpenServer_Click);
            // 
            // buttonOpenClient
            // 
            this.buttonOpenClient.Location = new System.Drawing.Point(50, 100);
            this.buttonOpenClient.Name = "buttonOpenClient";
            this.buttonOpenClient.Size = new System.Drawing.Size(150, 30);
            this.buttonOpenClient.TabIndex = 1;
            this.buttonOpenClient.Text = "Open Client Form";
            this.buttonOpenClient.UseVisualStyleBackColor = true;
            this.buttonOpenClient.Click += new System.EventHandler(this.buttonOpenClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Controls.Add(this.buttonOpenClient);
            this.Controls.Add(this.buttonOpenServer);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonOpenServer;
        private System.Windows.Forms.Button buttonOpenClient;
    }
}