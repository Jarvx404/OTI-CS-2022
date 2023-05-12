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

/*
   _____  ____  ______ _______            _____           ____  ______  _____  _____   _____          _____ _____            __ ____   ___   ___  
  / ____|/ __ \|  ____|__   __|     /\   |  __ \    /\   |  _ \|  ____|/ ____|/ ____| |  __ \   /\   / ____|_   _|   /\     /_ |___ \ / _ \ / _ \ 
 | (___ | |  | | |__     | |       /  \  | |__) |  /  \  | |_) | |__  | (___ | |      | |  | | /  \ | |      | |    /  \     | | __) | | | | | | |
  \___ \| |  | |  __|    | |      / /\ \ |  _  /  / /\ \ |  _ <|  __|  \___ \| |      | |  | |/ /\ \| |      | |   / /\ \    | ||__ <| | | | | | |
  ____) | |__| | |       | |     / ____ \| | \ \ / ____ \| |_) | |____ ____) | |____  | |__| / ____ | |____ _| |_ / ____ \   | |___) | |_| | |_| |
 |_____/ \____/|_|       |_|    /_/    \_|_|  \_/_/    \_|____/|______|_____/ \_____| |_____/_/    \_\_____|_____/_/    \_\  |_|____/ \___/ \___/                                                                                                                                
*/

namespace _2022
{

    
    public partial class InterferenteECO : Form
    {
        int[,] gameMatrix = new int[10, 20];

        private class Deflector{
            public int lin { get; set; }
            public int col { get; set; }
            public int CELLW { get; set; }
            public int CELLH { get; set; }

            int defState = 1;

            public void drawDeflector(Graphics g)
            {
                List<Point> pts = new List<Point>();
                switch (defState)
                {
                    case 0:
                        pts.Add(new Point(lin * CELLH - 10, col * CELLW - 10)); //ds
                        pts.Add(new Point((lin-1) * CELLH +10, col * CELLW - 10)); //ss
                        pts.Add(new Point(lin * CELLH - 10, (col+1) * CELLW + 10));
                        break;
                    case 1:
                        pts.Add(new Point((lin) * CELLH + 10, (col+1) * CELLW - 10)); //ds
                        pts.Add(new Point((lin-1) * CELLH + 10, col * CELLW - 10)); //ss
                        pts.Add(new Point((lin+1) * CELLH - 10, (col + 1) * CELLW - 10));
                        break;

                }
                Console.WriteLine(pts[0].X + " " + CELLW.ToString());
                g.FillPolygon(Brushes.White, pts.ToArray());
            }


        }


        private class Roomba
        {
            public int X { get; set;}
            public int Y { get; set;}   
             public int CELLW { get; set; }
            public int CELLH {get; set;}
            public Image roombaImage { get; set;}


            private enum moveDirection
            {
                UP, DOWN, LEFT, RIGHT, NONE
            };

            private moveDirection curDir;

            public void change(string md)
            {
                switch (md)
                {
                    case "UP":
                        this.curDir = moveDirection.UP;
                        break;
                    case "DOWN":
                        this.curDir = moveDirection.DOWN;
                        break;
                    case "LEFT":
                        this.curDir = moveDirection.LEFT;
                        break;
                    case "RIGHT":
                        this.curDir = moveDirection.RIGHT;
                        break;
                    default:
                        break;
                }
            }

            public void moveRoomba()
            {
                switch (curDir)
                {
                    case moveDirection.UP:
                        this.Y -= 1;
                        break;
                    case moveDirection.DOWN:
                        this.Y += 1;
                        break;
                    case moveDirection.LEFT:
                        this.X -= 1;
                        break;
                    case moveDirection.RIGHT:
                        this.X += 1;
                        break;
                    default:
                        break;
                }
            }

            public void drawRoomba(Graphics g)
            {
                g.DrawImage(
                this.roombaImage, 
                this.X*CELLW, 
                this.Y*CELLH,
                CELLW,
                CELLH
                );
            }
        }
        private class Element
        {
            public int lin { get; set; }
            public int col { get; set; }

            public int CELLW { get; set; }
            public int CELLH {get; set;}

            public Image imgElement { get; set; }

            public int eType { get; set; }  // 0-Meduza 1-Gunoi 

            public void draw(Graphics g)
            { 
                g.DrawImage(imgElement,
                col * CELLW, lin * CELLH,
                CELLW, CELLH);
            }
        }

        private Image backImage = null;
        private string personName = null;
        private List<Rectangle> robotPath = new List<Rectangle>();  

        public int CELL_WIDTH, CELL_HEIGHT;

        private bool grd = false;


        private List<Element> elemente;

        string[] medNames = { "Meduza1", "Meduza2", "Meduza3", "Meduza4" }; //Sti bancul cu meduza ? :) 
        string[] matsNames = { "Hartie", "Plastic", "Sticla" };


        Roomba roomba;



        public InterferenteECO(string personName, Image backImage)
        {
            
            InitializeComponent();

            

            CELL_WIDTH = gameBox.Width / 20; 
            CELL_HEIGHT = gameBox.Height / 10;

            gameBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameBox.Image = backImage;

            elemente = new List<Element>();

        }

        private void incarcaHarta()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (*.txt)|*.txt";
            string mapPath = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mapPath = ofd.FileName;
            }

            incarcaElemente(mapPath);
        }

        private void incarcaElemente(string mapPath)
        {
            string matPath = "./res/MaterialeReciclabile/";
            string medPath = "./res/Meduze/";
            string roPath = "./res/Robot/";

            StreamReader sr;
            try
            {
                sr = new StreamReader(mapPath);
            }catch(Exception ex)
            {
                return;
            }


            string line;
            char[] sep = { ' ' };

            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(sep);

                if (medNames.Contains(parts[0]))
                {
                    
                    elemente.Add(new Element
                    { 
                        lin = Convert.ToInt32(parts[1])-1,
                        col = Convert.ToInt32(parts[2])-1,
                        CELLW = CELL_WIDTH,
                        CELLH = CELL_HEIGHT,
                        imgElement = Image.FromFile(medPath + parts[0] + ".png"),
                        eType = 0
                    });
                }
                
                else if (matsNames.Contains(parts[0]))
                {
                    elemente.Add(new Element
                    {
                        lin = Convert.ToInt32(parts[1]) - 1,
                        col = Convert.ToInt32(parts[2]) - 1,
                        CELLW = CELL_WIDTH,
                        CELLH = CELL_HEIGHT,
                        imgElement = Image.FromFile(matPath + parts[0] + ".png"),
                        eType = 1
                    });
                }

                else
                {
                    roomba = new Roomba()
                    {
                        X = Convert.ToInt32(parts[1]) - 1,
                        Y = Convert.ToInt32(parts[2]) - 1,
                        CELLW = CELL_WIDTH,
                        CELLH = CELL_HEIGHT,
                        roombaImage = Image.FromFile(roPath + parts[0] + ".png"),
                    };
                    roomba.change("RIGHT");
                }
                
            }
        }

        private void gridCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(gridCheck.Checked) { grd = true; }
            else { grd = false; }
            gameBox.Invalidate();
        }



        // ---- Graphics Scetion ----
       // -- Refactor (niciodata) -- (respect tudor fortuna)
        private void drawGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Deflector def = new Deflector()
            {
                CELLH = CELL_HEIGHT,
                CELLW = CELL_WIDTH,
                lin = 3,
                col = 3,
            };

            def.drawDeflector(g);
            foreach (Element el in elemente)
            {
                el.draw(g);
            }
            for(int i=0; i < robotPath.Count; i += 1) { 
                if(i==0)
                    g.FillRectangle(Brushes.Orange, robotPath[i]);
                else
                    g.FillRectangle(Brushes.Purple, robotPath[i]);
            }

            if (roomba != null)
                roomba.drawRoomba(g);




            if (grd) { drawGrid(g); }
        }

        private void elementCollision()
        {
            foreach (Element el in elemente.ToList())
            {
                if(el.lin == roomba.Y && el.col == roomba.X)
                {
                    elemente.Remove(el);
                }
            }
            
        }
        private void drawGrid(Graphics g)
        { 

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
        
      

        private void loadBtn_Click(object sender, EventArgs e)
        {
            incarcaHarta();
            gameBox.Invalidate();
        }


        //TODO:Curata deflectoare 
        private void curBtn_Click(object sender, EventArgs e)
        {
            elemente.Clear();
            gameTimer.Stop();
            gameBox.Refresh();
        }

        private void svBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(gameBox.Width, gameBox.Height);
            gameBox.DrawToBitmap(bmp,
            new Rectangle(12,12, gameBox.Width, gameBox.Height)
            );

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Image (*.bmp)|*.bmp";
            sfd.InitialDirectory = "./res/Poze";

            string filePath = null;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
            }

            if (filePath != null)
            {
                bmp.Save(filePath);
            }
            else
            {
                MessageBox.Show("Locatie Invalida", "EROARE FATALA");
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void gameTick(object sender, EventArgs e)
        {
            robotPath.Add(new Rectangle
            {
               Width = CELL_WIDTH,
               Height = CELL_HEIGHT,
               X = roomba.X * CELL_WIDTH,
               Y = roomba.Y * CELL_HEIGHT   
            });


            roomba.moveRoomba();
            elementCollision();

            gameBox.Refresh();
        }
    }
}
