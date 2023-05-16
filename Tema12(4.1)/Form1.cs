using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tema12_4._1_
{
    public partial class Form1 : Form
    {
        SolidBrush mySolidBrush;
        TextureBrush myBrushTexture;
        HatchBrush myHatchBrush;
        LinearGradientBrush myBrushGrad;
        HatchStyle myHatchStyle;
        LinearGradientMode myLinearGradientMode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Pen myPen = new Pen(Color.Black, 1);

            // Рисование сплошной кистью
            int dx = 0;
            mySolidBrush = new SolidBrush(Color.Silver);
            g.FillRectangle(mySolidBrush, 20, 20, 200, 100);
            // рисование кистью со стандартными стилями
            dx += 210;
            myHatchStyle = HatchStyle.Cross;
            myHatchBrush = new HatchBrush(myHatchStyle, myPen.Color, mySolidBrush.Color);
            g.FillRectangle(myHatchBrush, 20 + dx, 20, 200, 100);

            // рисование кистью с градиентной заливкой
            dx += 210;
            myLinearGradientMode = LinearGradientMode.Horizontal;
            Rectangle r = new Rectangle(20 + dx, 20, 200, 100);
            myBrushGrad = new LinearGradientBrush(r, Color.White, Color.Gray, myLinearGradientMode);
            g.FillRectangle(myBrushGrad, r);

            // рисование текстурной кистью
            dx += 210;
            myBrushTexture = new TextureBrush(new Bitmap("C:\\\\Users\\USER\\Desktop\\\\T.bmp"));
            g.FillRectangle(myBrushTexture,new Rectangle(20 + dx, 20, 200, 100));


        }
    }
}
