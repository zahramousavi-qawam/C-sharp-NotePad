using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
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

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result =openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            { string Name = openFileDialog1.FileName;
                textBox2.Text = System.IO.File.ReadAllText(Name);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string name = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(name, textBox2.Text);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string name = saveFileDialog1.FileName;
            this.Text = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(name,textBox2.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.SelectedText = "";
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox2.Font = fontDialog1.Font;
            textBox2.ForeColor = fontDialog1.Color;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
