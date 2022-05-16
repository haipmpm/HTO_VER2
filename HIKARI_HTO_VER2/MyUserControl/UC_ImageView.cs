using HIKARI_HTO_VER2.MyForm;
using HIKARI_HTO_VER2.Properties;
using ImageGlass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIKARI_HTO_VER2.MyUserControl
{
    public partial class UC_ImageView : UserControl
    {
        private int default_Width_Images = 0;
        private RectangleF rect;
        ImageBoxZoomLevelCollection imgZoomLevel = new ImageBoxZoomLevelCollection();
        //Hình từ bên ngàoi muốn lấy theo hình trong này
        public UC_ImageView()
        {
            InitializeComponent();
            imgZoomLevel.Clear();
            for (int i = 10; i <= 600; i = i + 5)
            {
                imgZoomLevel.Add(i);
            }
            imageBox1.ZoomLevels = imgZoomLevel;
        }

        private void btn_RotateLeft_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                return;
            }

            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
            imageBox1.Image = bmp;
        }

        private void btn_RotateRight_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                return;
            }

            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imageBox1.Image = bmp;
        }
        public void setRectagle()
        {
            rect = imageBox1.GetSourceImageRegion();
        }
        public void AllowZoom(bool b)
        {
            imageBox1.AllowZoom = b;
        }
         public string LoadImage(string strURL, string strFileName, int iZoomValue)
        {
            try
            {
                PictureBox temp = new PictureBox();
                temp.Load(strURL);
                imageBox1.Zoom = iZoomValue;
                imageBox1.AutoScrollPosition = new Point(0, 0); // không set về mặc định ban đầu thì khi zoom lớn thì load hình bị mất
                //cache size before resize
                default_Width_Images = temp.Image.Width;

                //Load hình phụ
               

                // resize
                Bitmap bmap = new Bitmap(temp.Image , default_Width_Images + (Settings.Default.ZoomImageWidth * 10), temp.Image.Height);
                Bitmap newmap = bmap.Clone(new Rectangle(0, 0, bmap.Width, bmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                bmap.Dispose();

                imageBox1.Image = null;
                imageBox1.Image = newmap;
                //this.imageBox1.Image = temp.Image;

                imageBox1.SizeMode = ImageGlass.ImageBoxSizeMode.Normal;

                imageBox1.Image.Tag = strFileName;
                //double box = ((float)imageBox1.Width / (float)imageBox1.Height);
                //double image = ((float)imageBox1.Image.Width / (float)imageBox1.Image.Height);
                //double X = Settings.Default.PositionX/ box;
                //double Y = Settings.Default.PositionY / image - ((float)(Settings.Default.ZoomImageWidth) / (((float)imageBox1.Image.Width / (float)imageBox1.Width)));

                
                imageBox1.Zoom = iZoomValue;

                //RectangleF _view = imageBox1.GetSourceImageRegion();
                //imageBox1.AutoScrollPosition = new Point((int)Math.Round(_view.X), (int)Math.Round(_view.Y));

                imageBox1.ZoomChanged += imageBox1_ZoomChanged;
            }
            catch (System.Exception)
            {
                return "Error";
            }

            return "Ok";
        }

        private void imageBox1_ZoomChanged(object sender, EventArgs e)
        {
            //if (imageBox1.Zoom < iZoomMinimum)
            //{
            //    imageBox1.Zoom = iZoomMinimum;
            //}

            //if (imageBox1.Zoom > iZoomMax)
            //{
            //    imageBox1.Zoom = iZoomMax;
            //}
        }
       

        private void imageBox1_MouseHover(object sender, EventArgs e)
        {
            imageBox1.AllowZoom = true;
        }

        private void imageBox1_MouseLeave(object sender, EventArgs e)
        {
            imageBox1.AllowZoom = false;
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            imageBox1.SizeMode = ImageGlass.ImageBoxSizeMode.Normal;
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (Global.ControlFocusReturn is TextBox)
                    (Global.ControlFocusReturn as TextBox).Focus();
            }
            catch (Exception)
            {

            }
        }

        private void btn_ChangeZoom_Click(object sender, EventArgs e)
        {
            new frm_ChangeZoom().ShowDialog();
            try
            {
                if (imageBox1.Image == null)
                {
                    return;
                }

                Bitmap bmap = new Bitmap(imageBox1.Image, default_Width_Images + (Settings.Default.ZoomImageWidth * 10), imageBox1.Image.Height);
                Bitmap newmap = bmap.Clone(new Rectangle(0, 0, bmap.Width, bmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                bmap.Dispose();
                imageBox1.Image = null;
                imageBox1.Image = newmap;
                imageBox1.Zoom = Settings.Default.ZoomImage;
                imageBox1.ZoomChanged += imageBox1_ZoomChanged;
            }
            catch (Exception)
            {

            }
        }
    }
}
