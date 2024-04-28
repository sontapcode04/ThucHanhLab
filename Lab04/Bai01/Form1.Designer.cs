namespace Bai01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UDPClient = new System.Windows.Forms.Button();
            this.UDPServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPClient
            // 
            this.UDPClient.Location = new System.Drawing.Point(74, 57);
            this.UDPClient.Name = "UDPClient";
            this.UDPClient.Size = new System.Drawing.Size(105, 48);
            this.UDPClient.TabIndex = 0;
            this.UDPClient.Text = "UDPClient";
            this.UDPClient.UseVisualStyleBackColor = true;
            this.UDPClient.Click += new System.EventHandler(this.UDPClient_Click);
            // 
            // UDPServer
            // 
            this.UDPServer.Location = new System.Drawing.Point(297, 57);
            this.UDPServer.Name = "UDPServer";
            this.UDPServer.Size = new System.Drawing.Size(101, 48);
            this.UDPServer.TabIndex = 1;
            this.UDPServer.Text = "UDPServer";
            this.UDPServer.UseVisualStyleBackColor = true;
            this.UDPServer.Click += new System.EventHandler(this.UDPServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 162);
            this.Controls.Add(this.UDPServer);
            this.Controls.Add(this.UDPClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPClient;
        private System.Windows.Forms.Button UDPServer;
    }
}

