namespace Lab4
{
    partial class Lab04_Bai02
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(400, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(12, 38);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(400, 20);
            this.savePathTextBox.TabIndex = 1;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(418, 10);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 48);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 64);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(481, 309);
            this.webBrowser.TabIndex = 3;
            // 
            // Lab04_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 385);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Lab04_Bai02";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}