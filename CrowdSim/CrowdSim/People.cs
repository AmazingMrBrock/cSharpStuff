using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrowdSim
{
    class People
    {
        Random random = new Random();
        Stats stats = new Stats();

        public bool Extrovert;
        public int Attractiveness;
        public int Intelligence;
        public int Empathy;
        public int Courage;
        public int Stubbornness;
    }
}
