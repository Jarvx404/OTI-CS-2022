using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022
{
    public partial class Logare : Form
    {
        bool loggedIn = false;

        List<KeyValuePair<string, string>> logins;

        StreamReader sr = new StreamReader("./res/Useri.txt");
        string line;
        char[] split = { ' ' };

        public Logare()
        {
            InitializeComponent();
            logins = new List<KeyValuePair<string, string>>();
            loadData();


            foreach(Control pbx in this.Controls) { 
                if(pbx is PictureBox)
                {
                    pbx.Click += new EventHandler(imageClick);
                    ((PictureBox)pbx).SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

      
        private void loadData()
        {
            while((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(split);
                useriCombo.Items.Add(parts[0]);
                logins.Add(new KeyValuePair<string, string>(parts[0], parts[1]));
            }   
        }
        
        private bool valLogin()
        {
            if (useriCombo.SelectedItem is null || passBox.Text == "")
                return false;

            foreach (KeyValuePair<string,string> kvp in logins)
            {
                if (useriCombo.SelectedItem.Equals(kvp.Key)
                    && passBox.Text.Equals(kvp.Value))
                    {return true;}
            }

            return false;
        }

        
        private void imageClick(object sender, EventArgs e)
        {
            if(valLogin())
            {
                Image bgr = Image.FromFile("./res/Background/"+((PictureBox)sender).Name + ".jpg");
                InterferenteECO IE = new InterferenteECO(useriCombo.SelectedItem.ToString(), bgr);
                this.Hide();
                IE.Show();
            }
            else
            {
                useriCombo.SelectedItem = null;
                passBox.Text = string.Empty;

                MessageBox.Show("Datele de logare nu sunt corecte!");
            }
        }
    }
}
