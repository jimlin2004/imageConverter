namespace imageConverter
{
    partial class ImageConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnt_loadFile = new System.Windows.Forms.Button();
            this.label_picked = new System.Windows.Forms.Label();
            this.bnt_check = new System.Windows.Forms.Button();
            this.label_to = new System.Windows.Forms.Label();
            this.comboBox_to = new System.Windows.Forms.ComboBox();
            this.panel_to = new System.Windows.Forms.Panel();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.panel_imageView = new System.Windows.Forms.Panel();
            this.button_next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.pictureBox_imageView = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_to.SuspendLayout();
            this.panel_imageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_loadFile
            // 
            this.bnt_loadFile.AutoSize = true;
            this.bnt_loadFile.Location = new System.Drawing.Point(163, 74);
            this.bnt_loadFile.Name = "bnt_loadFile";
            this.bnt_loadFile.Size = new System.Drawing.Size(100, 40);
            this.bnt_loadFile.TabIndex = 0;
            this.bnt_loadFile.Text = "load file";
            this.bnt_loadFile.UseVisualStyleBackColor = true;
            this.bnt_loadFile.Click += new System.EventHandler(this.bnt_loadFile_Click);
            // 
            // label_picked
            // 
            this.label_picked.AutoEllipsis = true;
            this.label_picked.Location = new System.Drawing.Point(12, 190);
            this.label_picked.Name = "label_picked";
            this.label_picked.Size = new System.Drawing.Size(598, 19);
            this.label_picked.TabIndex = 3;
            this.label_picked.Text = "label_picked";
            this.label_picked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnt_check
            // 
            this.bnt_check.AutoSize = true;
            this.bnt_check.Location = new System.Drawing.Point(375, 147);
            this.bnt_check.Name = "bnt_check";
            this.bnt_check.Size = new System.Drawing.Size(100, 40);
            this.bnt_check.TabIndex = 4;
            this.bnt_check.Text = "convert";
            this.bnt_check.UseVisualStyleBackColor = true;
            this.bnt_check.Click += new System.EventHandler(this.bnt_check_Click);
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(0, 16);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(45, 19);
            this.label_to.TabIndex = 7;
            this.label_to.Text = "Type:";
            this.label_to.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_to
            // 
            this.comboBox_to.FormattingEnabled = true;
            this.comboBox_to.Items.AddRange(new object[] {
            "bmp",
            "dib",
            "hdr",
            "jpg",
            "jpe",
            "jp2",
            "jpeg",
            "pfm",
            "pic",
            "png",
            "pnm",
            "ppm",
            "sr",
            "tif",
            "tiff",
            "ras",
            "webp"});
            this.comboBox_to.Location = new System.Drawing.Point(51, 13);
            this.comboBox_to.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBox_to.Name = "comboBox_to";
            this.comboBox_to.Size = new System.Drawing.Size(150, 27);
            this.comboBox_to.TabIndex = 5;
            // 
            // panel_to
            // 
            this.panel_to.Controls.Add(this.comboBox_to);
            this.panel_to.Controls.Add(this.label_to);
            this.panel_to.Location = new System.Drawing.Point(112, 140);
            this.panel_to.Name = "panel_to";
            this.panel_to.Size = new System.Drawing.Size(205, 47);
            this.panel_to.TabIndex = 8;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_log.Location = new System.Drawing.Point(12, 212);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(600, 200);
            this.richTextBox_log.TabIndex = 9;
            this.richTextBox_log.Text = "";
            // 
            // panel_imageView
            // 
            this.panel_imageView.Controls.Add(this.button_next);
            this.panel_imageView.Controls.Add(this.button_previous);
            this.panel_imageView.Controls.Add(this.pictureBox_imageView);
            this.panel_imageView.Location = new System.Drawing.Point(360, 52);
            this.panel_imageView.Name = "panel_imageView";
            this.panel_imageView.Size = new System.Drawing.Size(128, 64);
            this.panel_imageView.TabIndex = 10;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(96, 0);
            this.button_next.Margin = new System.Windows.Forms.Padding(0);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(32, 64);
            this.button_next.TabIndex = 2;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_previous
            // 
            this.button_previous.Location = new System.Drawing.Point(64, 0);
            this.button_previous.Margin = new System.Windows.Forms.Padding(0);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(32, 64);
            this.button_previous.TabIndex = 1;
            this.button_previous.Text = "<";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // pictureBox_imageView
            // 
            this.pictureBox_imageView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_imageView.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_imageView.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_imageView.Name = "pictureBox_imageView";
            this.pictureBox_imageView.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imageView.TabIndex = 0;
            this.pictureBox_imageView.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(173, 2);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(302, 50);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "圖片轉檔小幫手";
            // 
            // ImageConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_imageView);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.panel_to);
            this.Controls.Add(this.bnt_check);
            this.Controls.Add(this.label_picked);
            this.Controls.Add(this.bnt_loadFile);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "ImageConverter";
            this.Text = "Image Converter";
            this.Load += new System.EventHandler(this.ImageConverter_Load);
            this.ResizeEnd += new System.EventHandler(this.ImageConverter_ResizeEnd);
            //this.Resize += new System.EventHandler(this.ImageConverter_Resize);
            this.panel_to.ResumeLayout(false);
            this.panel_to.PerformLayout();
            this.panel_imageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bnt_loadFile;
        private Label label_picked;
        private Button bnt_check;
        private Label label_to;
        private ComboBox comboBox_to;
        private Panel panel_to;
        private RichTextBox richTextBox_log;
        private Panel panel_imageView;
        private PictureBox pictureBox_imageView;
        private Button button_next;
        private Button button_previous;
        private Label label_title;
    }
}