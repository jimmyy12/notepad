using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // New button
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (textBox1.Text != "")
            {
               DialogResult result = MessageBox.Show("Doyou want to save changes to untitled?", "Notepad", MessageBoxButtons.YesNoCancel);
               if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem.PerformClick();
                    textBox1.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    textBox1.Text = "";
                }
            }
        }
        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //save button
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (textBox1.Text != "")
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
                save.ShowDialog();
            }
        }
        // New window button
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
