using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022
{
    public partial class InterferenteECO : Form
    {
        private Image backImage = null;
        private string personName = null;

        private bool grd = false;
        public InterferenteECO(string personName, Image backImage)
        {
            
            InitializeComponent();

            gameBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameBox.Image = backImage;

            gameTimer.Start();

        }

        private void gridCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(gridCheck.Checked) { grd = true; }
            else { grd = false; }
        }



        private void drawGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;    

            if(grd) { drawGrid(g); }
        }

        private void drawGrid(Graphics g)
        {
            int CELL_WIDTH = gameBox.Width / 20
            , CELL_HEIGHT = gameBox.Height / 10;

            Pen boxPen = new Pen(Brushes.White, 2);
            for(int i = 0; i < 10; i++)
                for(int j = 0; j < 20; j++)
                {
                    
                    g.DrawRectangle(boxPen,
                    new Rectangle(
                    new Point(j * CELL_WIDTH, i * CELL_HEIGHT),
                    new Size(CELL_WIDTH, CELL_HEIGHT)
                    ));
                }

        }

        private void gameTick(object sender, EventArgs e)
        {
            gameBox.Refresh();
        }
    }
}
