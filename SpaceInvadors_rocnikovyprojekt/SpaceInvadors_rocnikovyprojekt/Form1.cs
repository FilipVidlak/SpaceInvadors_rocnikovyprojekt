using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceInvadors_rocnikovyprojekt
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*WindowsMediaPlayer soundtrack = new WindowsMediaPlayer();
             WindowsMediaPlayer strela = new WindowsMediaPlayer();
            WindowsMediaPlayer exploze = new WindowsMediaPlayer();
            soundtrack.URL = "songs\\soundtrack.mp3"
            strela.URL = "songs\\strela.mp3";
            exploze.URL = "songs\\exploze.mp3";
            soundtrack.settings.setMode("loop", true);
             */
            label5.Visible = false;
            restart_button.Visible = false;
            exit_button.Visible = false;
            PictureBox[] neprlode = new PictureBox[10];
            PictureBox[] neprmun = new PictureBox[10];
            PictureBox[] municehrace = new PictureBox[4];
            PictureBox[] hvezdy = new PictureBox[8];
            Random rnd = new Random();
            /*
            Image enemi1 = Image.FromFile("asserts\\e1.png");
            Image enemi2 = Image.FromFile("asserts\\e2.png");
            Image enemi3 = Image.FromFile("asserts\\e3.png");
            Image boss1 = Image.FromFile("asserts\\boss1.png");
            Image boss2 = Image.FromFile("asserts\\boss2.png");
            Image municehrace = Image.FromFile("asserts\\municehrace.png");
            - grafiku krome sve vesmirne lode jsem zatim neresil
            */

            //inicializace nepratelskych lodi
            for (int i = 0; i < neprlode.Length; i++)
            {
                neprlode[i] = new PictureBox();
                neprlode[i].Size = new Size(35, 35);
                //neprlode[i].SizeMode = PictureBoxSizeMode.Zoom;
                neprlode[i].Visible = true;
                neprlode[i].BackColor = Color.Black; // pro ukazku
                //neprlode[i].BorderStyle = BorderStyle.None;
                neprlode[i].Location = new Point((i + 1) * 50, 10); //jinak ve vysce ma byt zaporna hodnota, aby priletali shora, ale to vse az budu mit timer 
                this.Controls.Add(neprlode[i]);
            }
            /*
            neprlode[0].Image = boss1;
            neprlode[1].Image = enemi2;
            neprlode[2].Image = enemi3;
            neprlode[3].Image = enemi3;
            neprlode[4].Image = enemi1;
            neprlode[5].Image = enemi3;
            neprlode[6].Image = enemi2;
            neprlode[7].Image = enemi3;
            neprlode[8].Image = enemi2;
            neprlode[9].Image = boss2;
            */
            //inicialize munice nepratelskych lodi
            for (int i = 0; i < neprmun.Length; i++)
            {
                neprmun[i] = new PictureBox();
                neprmun[i].Size = new Size(2, 20);
                neprmun[i].BackColor = Color.Red;
                neprmun[i].Visible = true;
                int random = rnd.Next(0, 10);
                neprmun[i].Location = new Point(neprlode[random].Location.X, neprlode[random].Location.Y + 40); // jen pro ukazku to mam zase kladnou hodnotu pri lokaci na vysku
                this.Controls.Add(neprmun[i]);
            }
            //inicializace munice hrace
            for (int i = 0; i < municehrace.Length; i++)
            {
                municehrace[i] = new PictureBox();
                municehrace[i].Size = new Size(6, 6);
                //munice[i].Image = municehrace;
                municehrace[i].SizeMode = PictureBoxSizeMode.Zoom;
                municehrace[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(municehrace[i]);
            }
            //inicializace hvezd na pozadi
            for (int i = 0; i < hvezdy.Length; i++)
            {
                hvezdy[i] = new PictureBox();
                hvezdy[i].BorderStyle = BorderStyle.None;
                int sirka = rnd.Next(20, 580);
                int vyska = rnd.Next(10, 400); // - zase jen pro ukazku, jinak zaporna hodnota, aby priletali seshora
                hvezdy[i].Location = new Point(sirka, vyska);
                if (i % 2 == 0)
                {
                    hvezdy[i].Size = new Size(3, 3);
                    hvezdy[i].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    hvezdy[i].Size = new Size(4, 4);
                    hvezdy[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(hvezdy[i]);
            }
            /*soundtrack.controls.play();*/
        }
    }
}
