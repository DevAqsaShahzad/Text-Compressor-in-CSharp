namespace IntegratedGUIandCode
{
    partial class Compression
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBoxPath = new System.Windows.Forms.ListBox();
            this.lblheading = new System.Windows.Forms.Label();
            this.btncompress = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnuploadpath = new System.Windows.Forms.Button();
            this.lblupload = new System.Windows.Forms.Label();
            this.lbltxtfile = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Maroon;
            this.panelheader.Controls.Add(this.btnminimize);
            this.panelheader.Controls.Add(this.btnexit);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1228, 60);
            this.panelheader.TabIndex = 9;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelheader_Paint);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.LightGray;
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.Maroon;
            this.btnminimize.Location = new System.Drawing.Point(1111, 5);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(38, 32);
            this.btnminimize.TabIndex = 1;
            this.btnminimize.Text = "-";
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightGray;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.Maroon;
            this.btnexit.Location = new System.Drawing.Point(1165, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 31);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listBoxPath
            // 
            this.listBoxPath.FormattingEnabled = true;
            this.listBoxPath.ItemHeight = 20;
            this.listBoxPath.Location = new System.Drawing.Point(259, 300);
            this.listBoxPath.Name = "listBoxPath";
            this.listBoxPath.Size = new System.Drawing.Size(489, 44);
            this.listBoxPath.TabIndex = 17;
            this.listBoxPath.SelectedIndexChanged += new System.EventHandler(this.listBoxPath_SelectedIndexChanged);
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblheading.Location = new System.Drawing.Point(85, 197);
            this.lblheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(449, 47);
            this.lblheading.TabIndex = 16;
            this.lblheading.Text = "For Text Compression";
            this.lblheading.Click += new System.EventHandler(this.lblheading_Click);
            // 
            // btncompress
            // 
            this.btncompress.BackColor = System.Drawing.Color.Maroon;
            this.btncompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btncompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompress.ForeColor = System.Drawing.Color.White;
            this.btncompress.Location = new System.Drawing.Point(981, 538);
            this.btncompress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncompress.Name = "btncompress";
            this.btncompress.Size = new System.Drawing.Size(153, 52);
            this.btncompress.TabIndex = 15;
            this.btncompress.Text = "COMPRESS";
            this.btncompress.UseVisualStyleBackColor = false;
            this.btncompress.Click += new System.EventHandler(this.btncompress_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(69, 538);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(150, 52);
            this.btnback.TabIndex = 14;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnuploadpath
            // 
            this.btnuploadpath.BackColor = System.Drawing.Color.Maroon;
            this.btnuploadpath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnuploadpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuploadpath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnuploadpath.Location = new System.Drawing.Point(784, 300);
            this.btnuploadpath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnuploadpath.Name = "btnuploadpath";
            this.btnuploadpath.Size = new System.Drawing.Size(183, 44);
            this.btnuploadpath.TabIndex = 13;
            this.btnuploadpath.Text = "Click Here";
            this.btnuploadpath.UseVisualStyleBackColor = false;
            this.btnuploadpath.Click += new System.EventHandler(this.btnuploadpath_Click);
            // 
            // lblupload
            // 
            this.lblupload.AutoSize = true;
            this.lblupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblupload.Location = new System.Drawing.Point(88, 315);
            this.lblupload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblupload.Name = "lblupload";
            this.lblupload.Size = new System.Drawing.Size(144, 29);
            this.lblupload.TabIndex = 12;
            this.lblupload.Text = "Upload File:";
            this.lblupload.Click += new System.EventHandler(this.lblupload_Click);
            // 
            // lbltxtfile
            // 
            this.lbltxtfile.AutoSize = true;
            this.lbltxtfile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbltxtfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltxtfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltxtfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbltxtfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltxtfile.Location = new System.Drawing.Point(248, 68);
            this.lbltxtfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtfile.Name = "lbltxtfile";
            this.lbltxtfile.Size = new System.Drawing.Size(615, 66);
            this.lbltxtfile.TabIndex = 11;
            this.lbltxtfile.Text = "Text-File Compression";
            this.lbltxtfile.Click += new System.EventHandler(this.lbltxtfile_Click);
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Maroon;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 613);
            this.panelfooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1228, 72);
            this.panelfooter.TabIndex = 10;
            this.panelfooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfooter_Paint);
            // 
            // Compression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1228, 685);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.listBoxPath);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.btncompress);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnuploadpath);
            this.Controls.Add(this.lblupload);
            this.Controls.Add(this.lbltxtfile);
            this.Controls.Add(this.panelfooter);
            this.Name = "Compression";
            this.Text = "Compression";
            this.Load += new System.EventHandler(this.Compression_Load);
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBoxPath;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btncompress;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnuploadpath;
        private System.Windows.Forms.Label lblupload;
        private System.Windows.Forms.Label lbltxtfile;
        private System.Windows.Forms.Panel panelfooter;
    }
}