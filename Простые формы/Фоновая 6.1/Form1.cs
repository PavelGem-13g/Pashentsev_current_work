using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Фоновая_6._1
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        SoundPlayer soundPlayer = new SoundPlayer();
        int delta;
        int normalAWidth;
        int normalBWidth;

        public Form1()
        {
            InitializeComponent();
            //if (File.Exists(Directory.GetCurrentDirectory() + "\\s.wav"))
            //{
            soundPlayer.Stream = Properties.Resources.s;
            //..\Music\Directory.GetCurrentDirectory() + "\\s.wav";
            //soundPlayer.Load();
            //}
            normalAWidth = A.Size.Width;
            normalBWidth = B.Size.Width;
            delta = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            if (B.Location.X - B.Size.Width - A.Location.X >= 0)
            {//-A.Size.Width
                B.Location = new Point(B.Location.X - delta, B.Location.Y);
                A.Location = new Point(A.Location.X + delta, A.Location.Y);
                ColorCanger();
                A.Size = new Size(A.Size.Width + 1, A.Size.Height + 1);
                B.Size = new Size(B.Size.Width + 1, B.Size.Height + 1);
            }

        }

        private void B_Click(object sender, EventArgs e)
        {
            if (A.Location.X > 0)
            {
                A.Location = new Point(A.Location.X - delta, A.Location.Y);
                ColorCanger();
                if (A.Size.Width > normalAWidth) A.Size = new Size(A.Size.Width - 1, A.Size.Height - 1);

            }
            if (B.Location.X + B.Size.Width < Size.Width - 20)
            {//B.Size.Width- 20
                B.Location = new Point(B.Location.X + delta, B.Location.Y);
                ColorCanger();

                if (B.Size.Width > normalBWidth) B.Size = new Size(B.Size.Width - 1, B.Size.Height - 1);
            }
        }
        void ColorCanger()
        {
            A.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            B.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            A.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            B.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            //if (File.Exists(Directory.GetCurrentDirectory() + "\\s.wav"))
            //{
            ///SystemSounds.Beep.Play();
            //}
            //soundPlayer.Stream = Properties.Resources.s;

            soundPlayer.Play();


        }



        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (B.Location.X + B.Size.Width + 15 > Size.Width)
            {
                B.Location = new Point(Size.Width - B.Size.Width - 15, 49);
            }
            if (A.Location.X + A.Size.Width + B.Size.Width + 40 > Size.Width)
            {
                A.Location = new Point(Size.Width - B.Size.Width - A.Size.Width - 40, 49);
            }


            //A.Location = new Point(94, 49);
            //B.Location = new Point(202,49);
        }
    }
}
