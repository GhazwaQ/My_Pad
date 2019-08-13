using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pad
{
    public partial class frmMyPad : Form
    {
        public frmMyPad()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Cut(); //to cut the text
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Copy(); //to copy the text
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste(); //to paste the text
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Undo(); //undo the actions
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();                //show dialog to choose a file name
            txtMain.SaveFile(sfd.FileName); //save text using this file name
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();                //show dialog to choose the file name that we want to open
            txtMain.LoadFile(ofd.FileName);  //open the text using the saved file name
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.ShowDialog();                //show the font dialog to show the font types
            txtMain.Font = fd.Font;        // allows to choose the font type 
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();               //show the colours dialog
            txtMain.BackColor = cd.Color; //allows to choose a colour for the background
        }

        private void foregroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            cd.ShowDialog();               //show the colours dialog
            txtMain.ForeColor = cd.Color; //allows to choose a colour for the text -forecolour-
        }
    }
}
