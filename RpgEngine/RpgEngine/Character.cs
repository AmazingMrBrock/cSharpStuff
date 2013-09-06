using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RpgEngine
{
    class Character
    {
        public string Name;

        public int BaseXp = 1000;
        public int CurrentXp;
        public int Level;
        public int NextXp; 

        public void Update()

        {
            Level = CurrentXp / 1000;
            NextXp = (Level * BaseXp) * 2 - CurrentXp;

            

        }
          
    }
}
