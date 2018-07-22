using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private String filestr;
        public Form1()
        {
            InitializeComponent();
            filestr = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hifiz muhammad Mashhood Notepad";
            this.textBox1.BorderStyle = BorderStyle.None;
            this.menuStrip1.AutoSize = true;
            this.fileToolStripMenuItem.Alignment = ToolStripItemAlignment.Left;
            this.newToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            this.lowerCaseToolStripMenuItem.Checked = true;
            this.textBox1.CharacterCasing = CharacterCasing.Normal;
            this.textBox1.ShortcutsEnabled=true;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.selecetAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.label1.Visible = false;
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.wordWrapToolStripMenuItem.Checked = true;
            this.menuStrip1.BackColor = Color.Silver;
            this.menuStrip1.ForeColor = Color.Black;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lowerCaseToolStripMenuItem.Checked == true)
            {
                this.lowerCaseToolStripMenuItem.Checked = false;
                this.upperCaseToolStripMenuItem.Checked = true;
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                this.lowerCaseToolStripMenuItem.Checked = true;
                this.upperCaseToolStripMenuItem.Checked = false;
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
            }
        }

       private void upperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upperCaseToolStripMenuItem.Checked == true)
            {
                this.upperCaseToolStripMenuItem.Checked = false;
                this.lowerCaseToolStripMenuItem.Checked = true;
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
            }
            else
            {
                this.lowerCaseToolStripMenuItem.Checked = false;
                this.upperCaseToolStripMenuItem.Checked = true;
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
            }
        }

       private void copyToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.Copy();
       }

       private void newToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (textBox1.Text != "")
           {

             DialogResult dr=  MessageBox.Show("Do you Want Save Chenges ?","", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
             if (dr == DialogResult.Yes)
             {
                 mySave();
             }
             else if (dr == DialogResult.No)
             {
                 this.textBox1.Text = "";
             }

           }

       }

       private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.Paste();
       }

       private void undoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.Undo();
       }

       private void abouUsToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
       }

       private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Creator Mashhood", "Mashhood NotePad", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

       public void textBox1_TextChanged(object sender, EventArgs e)
       {

       }

       private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.Cut();
           this.label1.Text="";
       }

       private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.SelectAll();
       }

       private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (timeDateToolStripMenuItem.Checked== false)
           {
               this.timeDateToolStripMenuItem.Checked = true;
               this.label1.Visible = true;
               this.label1.Text = System.DateTime.Today.ToString();
           }
           else
           {
               this.timeDateToolStripMenuItem.Checked = false;
               this.label1.Visible = false;
           }
       }

       private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (wordWrapToolStripMenuItem.Checked == true)
           {
               this.wordWrapToolStripMenuItem.Checked = false;
               this.textBox1.WordWrap = false;
           }
           else
           {
               this.wordWrapToolStripMenuItem.Checked = true;
               this.textBox1.WordWrap = true;
           }
       }

       private void fontToolStripMenuItem_Click(object sender, EventArgs e)
       {
       }

       private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           DialogResult dr = this.fontDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               this.textBox1.Font = this.fontDialog1.Font;
           }
       }

       private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.fontDialog1.ShowColor = true;
           DialogResult dr = this.fontDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               this.textBox1.Font = this.fontDialog1.Font;
               this.textBox1.ForeColor = this.fontDialog1.Color;
           }
       }

       private void selecetAllToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.textBox1.SelectAll();
       }

       private void findToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Form2 f2 = new Form2(this);
           f2.Show();
       }

       private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Form3 f3 = new Form3(this);
           f3.Show();
       }

       private void saveToolStripMenuItem_Click(object sender, EventArgs e)
       {
           mySave();
       }

       private void openToolStripMenuItem_Click(object sender, EventArgs e)
       {
           openFileDialog1.Filter = " | *.txt";
           DialogResult dr = openFileDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               String fname = openFileDialog1.FileName;
               this.textBox1.Text= File.ReadAllText(fname);
           }
       }

       public void mySave()
       {
           saveFileDialog1.Filter = " All Files | *.txt ";
           DialogResult dr = saveFileDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               String fname = saveFileDialog1.FileName;
               File.WriteAllText(fname, this.textBox1.Text);
           }
       }

       private void textAreaColourToolStripMenuItem_Click(object sender, EventArgs e)
       {
           DialogResult dr = colorDialog1.ShowDialog();
           if (dr == DialogResult.OK)
           {
               this.textBox1.BackColor = colorDialog1.Color;
           }
       }
    }
}
