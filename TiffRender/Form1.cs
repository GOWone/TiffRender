using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace TiffRender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pbxTiff.MouseWheel += new MouseEventHandler(PictureBox1_MouseWheel);
        }

        private async void btnRender_Click(object sender, EventArgs e)
        {
            FileInfo temp = new FileInfo(@"D:\CSharp_Projects\Demo\TiffRender\TiffRender\TiffRender\Source\Test_00000.tif");
            var tiffBitmap = await TiffRenderHelper.Tiff2BitmapSource(temp);
            this.pbxTiff.Image = Image.FromHbitmap(ToBitmap(tiffBitmap).GetHbitmap());
        }

        private void PictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.pbxTiff.Width = this.pbxTiff.Width * 9/10;
                this.pbxTiff.Height = this.pbxTiff.Height * 9/10;
            }
            else
            {
                this.pbxTiff.Width = this.pbxTiff.Width * 11 / 10;
                this.pbxTiff.Height = this.pbxTiff.Height * 11 / 10;
            }
        }

        /// <summary>
        /// 将 BitmapSource 转化为 Bitmap
        /// </summary>
        /// <param name="source"/>要转换的 BitmapSource
        /// <returns>转化后的 Bitmap</returns>
        public static Bitmap ToBitmap(BitmapSource source)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BitmapEncoder encoder = new BmpBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(source));
                encoder.Save(ms);
                return new Bitmap(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageZoom imageZoom = new ImageZoom();
            imageZoom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollapseDialogBox collapseDialogBox = new CollapseDialogBox();
            collapseDialogBox.Show();
        }
    }
}
