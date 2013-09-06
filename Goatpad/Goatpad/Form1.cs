using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        static String fileLoc;

        public Form1()
        {
            InitializeComponent();

            ContextMenu goatMenu = new ContextMenu();
            goatMenu.MenuItems.Add("Copy", copyToolStripMenuItem_Click);
            goatMenu.MenuItems.Add("Cut", cutToolStripMenuItem_Click);
            goatMenu.MenuItems.Add("Paste", pasteToolStripMenuItem_Click);
            goatMenu.MenuItems.Add("Delete", deleteToolStripMenuItem_Click);
            goatMenu.MenuItems.Add("Select All", selectAllToolStripMenuItem_Click);

            textBox1.ContextMenu = goatMenu;
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextReader tr;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = tr.ReadToEnd();
                    tr.Close();
                    fileLoc = openFileDialog1.FileName;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter tw = new StreamWriter(fileLoc);
                tw.Write(textBox1.Text);
                tw.Close();
            }

            catch (Exception saveEx)
            {
                MessageBox.Show(saveEx.Message, "Error");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter tw;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tw = new StreamWriter(saveFileDialog1.FileName);
                    tw.Write(textBox1.Text);
                    tw.Close();
                    fileLoc = saveFileDialog1.FileName;
                }

                catch (Exception saveEx)
                {
                    MessageBox.Show(saveEx.Message, "Error");
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.CheckState == CheckState.Checked)
            {
                wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
                textBox1.WordWrap = true;
            }
            else if (wordWrapToolStripMenuItem.CheckState == CheckState.Checked)
            {
                wordWrapToolStripMenuItem.CheckState = CheckState.Unchecked;
                textBox1.WordWrap = false;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutGoatpad f2 = new AboutGoatpad();
            f2.Show();

        }



    }
}
