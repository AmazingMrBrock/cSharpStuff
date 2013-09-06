using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Artist
{
    public partial class Form1 : Form
    {
        Thread animation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            Artist art = new Artist();
            art.setCanvas(panel1);

            animation = new Thread(new ThreadStart(art.StartAnimation));
            animation.Start();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            animation.Abort();
        }
    }
}
