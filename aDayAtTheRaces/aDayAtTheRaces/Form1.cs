using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        Guy al;
        int bank = 1000;

        public void UpdateForm()
        {
            JoeRadioButton.Text = joe.Name + " has $" + joe.Cash;
            BobRadioButton.Text = bob.Name + " has $" + bob.Cash;
            JoeRadioButton.Text = al.Name + " has $" + al.Cash;
        }

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "Joe"};

            bob = new Guy() { Cash = 50, Name = "Bob" };

            al = new Guy() { Cash = 50, Name = "Al" };

            UpdateForm();
        }


    }
}
