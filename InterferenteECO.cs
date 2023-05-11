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
        public InterferenteECO(string personName, Image backImage)
        {
            
            InitializeComponent();

            gameBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameBox.Image = backImage;

        }
    }
}
