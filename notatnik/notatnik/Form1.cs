using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patryk Łąpieś");
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
                if (sv.ShowDialog() == DialogResult.OK)
                    richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cZcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cr.Color;
            }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

    }
}
