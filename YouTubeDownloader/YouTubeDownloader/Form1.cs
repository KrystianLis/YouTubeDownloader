using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YouTubeDownloader
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxResolution.SelectedIndex = 2;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            IEnumerable<VideoInfo> vid = DownloadUrlResolver.GetDownloadUrls(textUrl.Text);   //It doesn't work for some URLs
            VideoInfo video = vid.First(n => n.VideoType == VideoType.Mp4 && n.Resolution == Convert.ToInt32(ComboBoxResolution.Text));
            
            if(video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            VideoDownloader dLoader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));
            dLoader.DownloadProgressChanged += Downloader_DownloadProgressCHanged;

            Thread thread = new Thread(() => { dLoader.Execute(); })
            {
                IsBackground = true
            };

            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Downloader_DownloadProgressCHanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                ProgressBar.Value = (int)e.ProgressPercentage;
                lbPercent.Text = $"{string.Format("{0:0}", e.ProgressPercentage)}%";
                ProgressBar.Update();
            }));
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
