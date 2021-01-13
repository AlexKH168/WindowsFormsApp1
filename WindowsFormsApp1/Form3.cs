using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string _path = @"C:\Users\TryDev\Desktop\";

        private void button1_Click(object sender, EventArgs e)
        {
            //ResizeImage(pictureBox1.Image, 540, 960).Save(@"C:\Users\TryDev\Desktop\resized.jpg");

            VaryQualityLevel(pictureBox1.Image, 500, 714, _path, "thumbnail_resized.jpg");
            VaryQualityLevel(pictureBox2.Image, 1024, 679, _path, "poster_resized.jpg");
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.Default;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.Default;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox1);
        }
        
        private void LoadImage(PictureBox picture)
        {
            try
            {
                //Getting The Image From The System
                OpenFileDialog open = new OpenFileDialog();
                open.Filter =
                  "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    picture.ImageLocation = open.FileName;
                }
                else
                {
                    picture.ImageLocation = "";
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void VaryQualityLevel(Image image, int width, int height, string path, string fileName)
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use.  
            //using (Bitmap bmp1 = new Bitmap(@"C:\Users\TryDev\Desktop\resized.jpg"))
            //{
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID  
            // for the Quality parameter category.  
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.  
            // An EncoderParameters object has an array of EncoderParameter  
            // objects. In this case, there is only one  
            // EncoderParameter object in the array.  
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 8 0L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            ResizeImage(image, width, height).Save(path + fileName, jpgEncoder, myEncoderParameters);

            // Save the bitmap as a JPG file with zero quality level compression.  
            //myEncoderParameter = new EncoderParameter(myEncoder, 0L);
            //myEncoderParameters.Param[0] = myEncoderParameter;
            //bmp1.Save(@"C:\Users\TryDev\Desktop\QualityZero.jpg", jpgEncoder, myEncoderParameters);
            //}
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox2);
        }
    }
}

#region Referrent URL
/*** Resize Image ***/
//https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
/*** Set Quality ***/
//https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-set-jpeg-compression-level?view=netframeworkdesktop-4.8&redirectedfrom=MSDN
#endregion
