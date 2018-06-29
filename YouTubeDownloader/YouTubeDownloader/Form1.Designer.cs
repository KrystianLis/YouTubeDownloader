namespace YouTubeDownloader
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.ComboBoxResolution = new System.Windows.Forms.ComboBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lbPercent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(492, 81);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(74, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(13, 26);
            this.textUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(554, 23);
            this.textUrl.TabIndex = 1;
            this.textUrl.Text = "https://www.youtube.com/watch?v=obvizJRnezA";
            // 
            // ComboBoxResolution
            // 
            this.ComboBoxResolution.FormattingEnabled = true;
            this.ComboBoxResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.ComboBoxResolution.Location = new System.Drawing.Point(13, 82);
            this.ComboBoxResolution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxResolution.Name = "ComboBoxResolution";
            this.ComboBoxResolution.Size = new System.Drawing.Size(122, 24);
            this.ComboBoxResolution.TabIndex = 4;
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(13, 54);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(553, 23);
            this.ProgressBar.TabIndex = 7;
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPercent.Location = new System.Drawing.Point(371, 87);
            this.lbPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(29, 17);
            this.lbPercent.TabIndex = 8;
            this.lbPercent.Text = "0%";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(414, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 22);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ComboBoxResolution);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.ComboBox ComboBoxResolution;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

