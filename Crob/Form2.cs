using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 morenash = new Form1();
            int x;
            int y;
            Random rn = new Random(Guid.NewGuid().GetHashCode());
            Random ra = new Random(Guid.NewGuid().GetHashCode());
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            x = rn.Next(0, Screen.PrimaryScreen.WorkingArea.Width);
            y = ra.Next(0, Screen.PrimaryScreen.WorkingArea.Height);
            morenash.StartPosition = FormStartPosition.Manual;
            morenash.Location = new Point(x, y);
            morenash.Show();
        }
    }
}
