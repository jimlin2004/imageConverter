using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace imageConverter.src
{
    public class FFmpegApi
    {
        public FFmpegApi()
        {

        }

        [DllImport(@"imageConverter_cpp.dll", EntryPoint = "imageConvert", CallingConvention = CallingConvention.StdCall)]
        private static extern int imageConvert(string path, string output);

        private string errorCodeTranslate(int errorCode, string file, RichTextBox log)
        {
            switch (errorCode)
            {
                case 0:
                    log.SelectionColor = Color.White;
                    return $"[INFO] {file} complete\r\n";
                case 1:
                    log.SelectionColor = Color.Red;
                    return $"[ERROR] Can not open {file}\r\n";
                default:
                    log.SelectionColor = Color.Yellow;
                    return "[WARNING] Unknow errorCode\r\n";
            }
        }

        public void convert(string[] files, string to, RichTextBox log)
        {
            string output = "";
            int errorCode = 0;
            Dictionary<string, int> map = new Dictionary<string, int>()
            {
                {"success", 0}, {"error", 0}
            };
            log.Text = "";
            foreach (string file in files)
            {
                output = Path.GetDirectoryName(file);
                output = Path.Combine(output, Path.GetFileNameWithoutExtension(file) + '.' + to);
                errorCode = imageConvert(file, output);
                if (errorCode == 0)
                    map["success"]++;
                else if (errorCode == 1)
                    map["error"]++;
                log.AppendText(errorCodeTranslate(errorCode, file, log));
                log.SelectionStart = log.Text.Length;
                log.ScrollToCaret();
            }
            log.SelectionColor = Color.White;
            log.AppendText("----------------\r\n");
            log.SelectionColor = Color.GreenYellow;
            log.AppendText($"Success: {map["success"]} / {files.Length}\r\n");
            log.SelectionColor = Color.Red;
            log.AppendText($"Error: {map["error"]}\r\n");
            log.SelectionStart = log.Text.Length;
            log.ScrollToCaret();
        }
    }
}
