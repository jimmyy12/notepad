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
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            save.FilterIndex = 1;
            save.RestoreDirectory = true;
            if (textBox1.Text != "")
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(save.FileName,textBox1.Text);
                }
            };
        }
        // New window button
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        //open button
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            //  OpenFileDialog1.ShowDialog();
            {
                OpenFileDialog1.InitialDirectory = @"C:\";
                OpenFileDialog1.RestoreDirectory = true;
                OpenFileDialog1.Title = "Browse Text Files";
                OpenFileDialog1.DefaultExt = "txt";
                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                OpenFileDialog1.CheckFileExists = true;
                OpenFileDialog1.CheckPathExists = true;
            };
            {
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                        textBox1.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName);
                    
                }
            };
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            save.FilterIndex = 1;
            save.RestoreDirectory = true;
            if (textBox1.Text != "")
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(save.FileName, textBox1.Text);
                }
            };
        }
    }
}
