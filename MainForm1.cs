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

namespace Astronomy
{
    public partial class MainForm1 : Form
    {
        static Queue<Planet> queue = new Queue<Planet>();

        InformationForm informationForm = new InformationForm();

        public MainForm1()
        {
            queue.Enqueue(new Planet(Planets.Earth, 152100000, 147095000, 147095000, 365));
            queue.Enqueue(new Planet(Planets.Jupiter, 816, 740, 740, 4332));
            queue.Enqueue(new Planet(Planets.Mars, 249200000, 206700000, 206700000, 687));
            queue.Enqueue(new Planet(Planets.Mercury, 69816900, 46001200, 57909050, 88));
            queue.Enqueue(new Planet(Planets.Neptune, 4540000000, 4460000000, 4500000000, 60195));
            queue.Enqueue(new Planet(Planets.Saturn, 1514500, 1352500, 1432500, 10759));
            queue.Enqueue(new Planet(Planets.Uranus, 200962325, 180962325, 190962325, 30688));
            queue.Enqueue(new Planet(Planets.Venus, 108939000, 108939000, 108208000, 224));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            var x = 30;
            var y = 200;
             
         
            foreach(var item in queue)
            { 
                var currentPlanet = item;
  
                var pb = (new PictureBox()
                {
                    BackgroundImage = currentPlanet.PlanetImage,
                    BackColor = Color.Transparent,
                    Size = new Size(70, 70),
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Visible = true,
                    Location = new Point(x, y),
                });

                
                
                pb.Click += (s, ea) =>
                {
                    
                    var pictureToChange =  informationForm.Controls.OfType<PictureBox>().ToArray()[0];
                    pictureToChange.BackgroundImage = currentPlanet.PlanetImage;
                    pictureToChange.BackgroundImageLayout = ImageLayout.Zoom;

                    var textToChange = informationForm.Controls.OfType<TextBox>().ToArray()[1];
                    textToChange.Text = currentPlanet.ToString();
                    this.Hide();
                    informationForm.Show();
                };
                Controls.Add(pb);

                Controls.Add(new TextBox() { Text = currentPlanet.Name.ToString(), Location = new Point(x + 25, y - 30), 
                    Size = new Size(50, 30), ReadOnly = true, BorderStyle = BorderStyle.None, BackColor = Color.Black, ForeColor = Color.White });
                
                x += 100;
                
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            Application.Exit();
        }
    }
    }

