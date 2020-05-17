using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Фоновая_6._1
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        SoundPlayer soundPlayer = new SoundPlayer();
        int delta;
        public Form1()
        {
            InitializeComponent();
            //if (File.Exists(Directory.GetCurrentDirectory() + "\\s.wav"))
            //{
                soundPlayer.Stream = Properties.Resources.s;
                //..\Music\Directory.GetCurrentDirectory() + "\\s.wav";
                //soundPlayer.Load();
            //}
            delta = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            if (B.Location.X - A.Location.X >= 65)
            {
                B.Location = new Point(B.Location.X - delta, B.Location.Y);
                A.Location = new Point(A.Location.X + delta, A.Location.Y);
                ColorCanger();

            }

        }

        private void B_Click(object sender, EventArgs e)
        {
            if (A.Location.X > 5)
            {
                A.Location = new Point(A.Location.X - delta, A.Location.Y);
                ColorCanger();
            }
            if (B.Location.X < Size.Width - 80)
            {
                B.Location = new Point(B.Location.X + delta, B.Location.Y);
                ColorCanger();
            }
        }
        void ColorCanger()
        {
            A.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            B.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //if (File.Exists(Directory.GetCurrentDirectory() + "\\s.wav"))
            //{
            ///SystemSounds.Beep.Play();
            //}
            //soundPlayer.Stream = Properties.Resources.s;

            soundPlayer.Play();


        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (B.Location.X+ B.Size.Width+20 > Size.Width) 
            {
                B.Location = new Point(Size.Width-B.Size.Width-5,49);
            }
            if (A.Location.X + A.Size.Width + B.Size.Width + 40 > Size.Width)
            {
                A.Location = new Point(Size.Width - B.Size.Width-A.Size.Width - 10, 49);
            }


            //A.Location = new Point(94, 49);
            //B.Location = new Point(202,49);
        }
    }
}
