using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading; 

namespace Artist
{
    class Artist
    {
        Panel canvas;
        
        public void StartAnimation()
        {
            Graphics g = canvas.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Brush black = new SolidBrush(Color.Black);
            Rectangle sprite = new Rectangle(225, -50, 50, 50);

            while (sprite.Y < 500)
            {
                g.FillRectangle(black, sprite);
                sprite.Y += 6;
                g.FillRectangle(red, sprite);
                Thread. Sleep(25);
            }
        }

        public void setCanvas(Panel p) { canvas = p; }

    }
}
