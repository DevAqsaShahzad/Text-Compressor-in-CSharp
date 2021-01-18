namespace IntegratedGUIandCode
{
    partial class Main
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
            this.btntxtDecompression = new System.Windows.Forms.Button();
            this.btntxtCompression = new System.Windows.Forms.Button();
            this.lbltxtDecompression = new System.Windows.Forms.Label();
            this.lbltxtCompression = new System.Windows.Forms.Label();
            this.lblTxtFile = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelheader.BackColor = System.Drawing.Color.Maroon;
            this.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelheader.Controls.Add(this.btnminimize);
            this.panelheader.Controls.Add(this.btnexit);
            this.panelheader.Location = new System.Drawing.Point(-71, -7);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1589, 100);
            this.panelheader.TabIndex = 9;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.LightGray;
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.Maroon;
            this.btnminimize.Location = new System.Drawing.Point(1123, 32);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(36, 33);
            this.btnminimize.TabIndex = 8;
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
            this.btnexit.Location = new System.Drawing.Point(1183, 31);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(38, 33);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btntxtDecompression
            // 
            this.btntxtDecompression.BackColor = System.Drawing.Color.Maroon;
            this.btntxtDecompression.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntxtDecompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntxtDecompression.ForeColor = System.Drawing.Color.White;
            this.btntxtDecompression.Location = new System.Drawing.Point(469, 399);
            this.btntxtDecompression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntxtDecompression.Name = "btntxtDecompression";
            this.btntxtDecompression.Size = new System.Drawing.Size(212, 54);
            this.btntxtDecompression.TabIndex = 8;
            this.btntxtDecompression.Text = "Click Here";
            this.btntxtDecompression.UseVisualStyleBackColor = false;
            this.btntxtDecompression.Click += new System.EventHandler(this.btntxtDecompression_Click);
            // 
            // btntxtCompression
            // 
            this.btntxtCompression.BackColor = System.Drawing.Color.Maroon;
            this.btntxtCompression.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntxtCompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntxtCompression.ForeColor = System.Drawing.Color.White;
            this.btntxtCompression.Location = new System.Drawing.Point(469, 290);
            this.btntxtCompression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntxtCompression.Name = "btntxtCompression";
            this.btntxtCompression.Size = new System.Drawing.Size(212, 55);
            this.btntxtCompression.TabIndex = 7;
            this.btntxtCompression.Text = "Click Here";
            this.btntxtCompression.UseVisualStyleBackColor = false;
            this.btntxtCompression.Click += new System.EventHandler(this.btntxtCompression_Click);
            // 
            // lbltxtDecompression
            // 
            this.lbltxtDecompression.AutoSize = true;
            this.lbltxtDecompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtDecompression.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltxtDecompression.Location = new System.Drawing.Point(176, 409);
            this.lbltxtDecompression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtDecompression.Name = "lbltxtDecompression";
            this.lbltxtDecompression.Size = new System.Drawing.Size(285, 29);
            this.lbltxtDecompression.TabIndex = 13;
            this.lbltxtDecompression.Text = "For Text Decompression:";
            // 
            // lbltxtCompression
            // 
            this.lbltxtCompression.AutoSize = true;
            this.lbltxtCompression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtCompression.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltxtCompression.Location = new System.Drawing.Point(179, 300);
            this.lbltxtCompression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxtCompression.Name = "lbltxtCompression";
            this.lbltxtCompression.Size = new System.Drawing.Size(259, 29);
            this.lbltxtCompression.TabIndex = 12;
            this.lbltxtCompression.Text = "For Text Compression:";
            // 
            // lblTxtFile
            // 
            this.lblTxtFile.AutoSize = true;
            this.lblTxtFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTxtFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTxtFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTxtFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTxtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTxtFile.Location = new System.Drawing.Point(171, 97);
            this.lblTxtFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxtFile.Name = "lblTxtFile";
            this.lblTxtFile.Size = new System.Drawing.Size(615, 66);
            this.lblTxtFile.TabIndex = 11;
            this.lblTxtFile.Text = "Text-File Compression";
            this.lblTxtFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTxtFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Maroon;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 577);
            this.panelfooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1175, 77);
            this.panelfooter.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1175, 654);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.btntxtDecompression);
            this.Controls.Add(this.btntxtCompression);
            this.Controls.Add(this.lbltxtDecompression);
            this.Controls.Add(this.lbltxtCompression);
            this.Controls.Add(this.lblTxtFile);
            this.Controls.Add(this.panelfooter);
            this.Name = "Main";
            this.Text = "Main";
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btntxtDecompression;
        private System.Windows.Forms.Button btntxtCompression;
        private System.Windows.Forms.Label lbltxtDecompression;
        private System.Windows.Forms.Label lbltxtCompression;
        private System.Windows.Forms.Label lblTxtFile;
        private System.Windows.Forms.Panel panelfooter;
    }
}

