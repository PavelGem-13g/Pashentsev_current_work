using System;
using System.Drawing;
using System.Windows.Forms;

namespace Фоновая_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            if (B.Location.X - A.Location.X >= 65)
            {
                B.Location = new Point(B.Location.X - 5, B.Location.Y);
                A.Location = new Point(A.Location.X + 5, A.Location.Y);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (A.Location.X > 5)
            {
                A.Location = new Point(A.Location.X-5,A.Location.Y);
            }
            if (B.Location.X < Size.Width-80)
            {
                B.Location = new Point(B.Location.X + 5, B.Location.Y);
            }
        }
    }
}
