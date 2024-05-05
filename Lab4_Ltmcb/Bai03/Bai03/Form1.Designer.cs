namespace Bai03
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnDownFile = new System.Windows.Forms.Button();
            this.btnDownRecource = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtfileurl = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(33, 76);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(726, 362);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(33, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(114, 14);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(578, 22);
            this.txtLink.TabIndex = 2;
            // 
            // btnDownFile
            // 
            this.btnDownFile.Location = new System.Drawing.Point(486, 42);
            this.btnDownFile.Name = "btnDownFile";
            this.btnDownFile.Size = new System.Drawing.Size(119, 23);
            this.btnDownFile.TabIndex = 3;
            this.btnDownFile.Text = "Down Files";
            this.btnDownFile.UseVisualStyleBackColor = true;
            this.btnDownFile.Click += new System.EventHandler(this.btnDownFile_Click);
            // 
            // btnDownRecource
            // 
            this.btnDownRecource.Location = new System.Drawing.Point(628, 42);
            this.btnDownRecource.Name = "btnDownRecource";
            this.btnDownRecource.Size = new System.Drawing.Size(122, 23);
            this.btnDownRecource.TabIndex = 4;
            this.btnDownRecource.Text = "Down Recource";
            this.btnDownRecource.UseVisualStyleBackColor = true;
            this.btnDownRecource.Click += new System.EventHandler(this.btnDownRecource_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(698, 14);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtfileurl
            // 
            this.txtfileurl.Location = new System.Drawing.Point(33, 42);
            this.txtfileurl.Name = "txtfileurl";
            this.txtfileurl.Size = new System.Drawing.Size(421, 22);
            this.txtfileurl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.txtfileurl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnDownRecource);
            this.Controls.Add(this.btnDownFile);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnDownFile;
        private System.Windows.Forms.Button btnDownRecource;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtfileurl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

