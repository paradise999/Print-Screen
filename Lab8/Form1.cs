using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Bitmap TakeScreenShot(Screen currentScreen)
        {
            Bitmap bmpScreenShot = new Bitmap(currentScreen.Bounds.Width,
                                              currentScreen.Bounds.Height,
                                              System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics gScreenShot = Graphics.FromImage(bmpScreenShot);

            gScreenShot.CopyFromScreen(currentScreen.Bounds.X,
                                       currentScreen.Bounds.Y,
                                       0, 0,
                                       currentScreen.Bounds.Size,
                                       CopyPixelOperation.SourceCopy);
            return bmpScreenShot;
        }

        private Bitmap bmp;
        private void screenshot_Click(object sender, EventArgs e)
        {

            // это действие задаёт параметр расположения
            //изображения в pictureBox1
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //Делаем снимок экрана (изображение в памяти)
            Image pr = TakeScreenShot(Screen.PrimaryScreen);

            //Создание экземпляра класса Bitmap, в котом  
            //будет короткое время храниться наше изображение
            bmp = new Bitmap(pr);

            //Впихиваем изображение в pictureBox1
            pictureBox1.Image = bmp;

        }

        private void save_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("скриншот.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
