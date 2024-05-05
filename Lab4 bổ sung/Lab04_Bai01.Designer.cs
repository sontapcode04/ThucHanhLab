namespace Lab4
{
    partial class Lab04_Bai01
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtHTMLContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(366, 20);
            this.txtURL.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(384, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Hiển thị";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtHTMLContent
            // 
            this.txtHTMLContent.Location = new System.Drawing.Point(12, 38);
            this.txtHTMLContent.Multiline = true;
            this.txtHTMLContent.Name = "txtHTMLContent";
            this.txtHTMLContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHTMLContent.Size = new System.Drawing.Size(447, 239);
            this.txtHTMLContent.TabIndex = 2;
            // 
            // Lab04_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 289);
            this.Controls.Add(this.txtHTMLContent);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtURL);
            this.Name = "Lab04_Bai01";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtHTMLContent;
    }
}