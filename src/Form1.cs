using imageConverter.src;

namespace imageConverter
{
    public partial class ImageConverter : Form
    {
        private FFmpegApi ffmpegApi;
        private string[] files;
        private List<HorizontalContainer> levels;
        private int currentImgIndex;
        private const int WM_SYSCOMMAND = 0x112;
        //private const int SC_CLOSE = 0xF060;
        //private const int SC_MINIMIZE = 0xF020;
        private const int SC_RESTORE = 0xF120;
        private const int SC_MAXIMIZE = 0xF030;

        public ImageConverter()
        {
            InitializeComponent();

            this.ffmpegApi = new FFmpegApi();
            this.files = new string[] {};
            this.levels = new List<HorizontalContainer>();
            this.currentImgIndex = 0;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_SYSCOMMAND)
            {
                int msgWParam = m.WParam.ToInt32();
                if (msgWParam == SC_MAXIMIZE || msgWParam == SC_RESTORE)
                {
                    this.maximizeEventHandle();
                }
            }
            return;
        }

        private void maximizeEventHandle()
        {
            this.resizeLog();
            this.arrangeAllLevels();
            this.resetLabel_picked();
        }

        private void arrangeAllLevels()
        {
            foreach (HorizontalContainer level in this.levels)
            {
                level.autoArrange(this.ClientSize.Width);
            }
            return;
        }

        private void resizeLog()
        {
            this.richTextBox_log.Width = this.ClientSize.Width - 40;
            this.richTextBox_log.Height = this.ClientSize.Height - this.richTextBox_log.Location.Y - 20;
            return;
        }

        private void ImageConverter_Load(object sender, EventArgs e)
        {
            this.levels.Add(new HorizontalContainer(this.label_title));
            this.levels.Add(new HorizontalContainer(this.bnt_loadFile, this.panel_imageView));
            this.levels.Add(new HorizontalContainer(this.panel_to, this.bnt_check));
            this.levels.Add(new HorizontalContainer(this.label_picked));
            this.levels.Add(new HorizontalContainer(this.richTextBox_log));
            this.label_picked.Text = "尚未選擇檔案";
            this.resizeLog();
            this.arrangeAllLevels();
            return;
        }

        private void ImageConverter_ResizeEnd(object sender, EventArgs e)
        {
            this.resizeLog();
            this.arrangeAllLevels();
            this.resetLabel_picked();
            return;
        }

        private void resetLabel_picked()
        {
            int width = this.ClientSize.Width - 20;
            this.label_picked.Size = new Size(width, this.label_picked.Size.Height);
            int midlineX = this.ClientSize.Width / 2;
            int x = midlineX - (this.label_picked.Width / 2);
            this.label_picked.Location = new Point(x, this.label_picked.Location.Y);
            return;
        }

        private void pictureBox_imageView_changeImg(int imgIndex)
        {
            if (this.files.Length == 0)
                return;
            try
            {
                this.pictureBox_imageView.Load(this.files[imgIndex]);
            }
            catch (ArgumentException e)
            {
                this.pictureBox_imageView.Image = null;
                this.richTextBox_log.SelectionColor = Color.Red;
                this.richTextBox_log.AppendText($"[Error] Can not display {this.files[imgIndex]}\r\n");
                this.richTextBox_log.SelectionStart = this.richTextBox_log.Text.Length;
                this.richTextBox_log.ScrollToCaret();
            }
            catch (FileNotFoundException e)
            {
                this.pictureBox_imageView.Image = null;
                this.richTextBox_log.SelectionColor = Color.Red;
                this.richTextBox_log.AppendText($"[Error] Can not found {this.files[imgIndex]}\r\n[Error] Please check if {this.files[imgIndex]} exists\r\n");
                this.richTextBox_log.SelectionStart = this.richTextBox_log.Text.Length;
                this.richTextBox_log.ScrollToCaret();
            }
            this.currentImgIndex = imgIndex;
            return;
        }

        private void bnt_loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇檔案";
            dialog.Filter = "所有檔案(*.*)|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.label_picked.Text = "file name: ";
                foreach (string file in dialog.FileNames)
                {
                    this.label_picked.Text += file;
                }
                this.files = dialog.FileNames;
            }
            this.resetLabel_picked();
            this.pictureBox_imageView_changeImg(0);
            return;
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (this.files.Length == 0)
                return;
            this.currentImgIndex = Math.Max(--this.currentImgIndex, 0);
            this.pictureBox_imageView_changeImg(this.currentImgIndex);
            return;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (this.files.Length == 0)
                return;
            this.currentImgIndex = Math.Min(++this.currentImgIndex, this.files.Length - 1);
            this.pictureBox_imageView_changeImg(this.currentImgIndex);
            return;
        }

        private void bnt_check_Click(object sender, EventArgs e)
        {
            this.ffmpegApi.convert(this.files, this.comboBox_to.Text, this.richTextBox_log);
            return;
        }
    }
}