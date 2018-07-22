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
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label1.Text = "Do you Want Save Chenges ?";
            this.button1.Text = "Save";
            this.button2.Text = "Dont Save";
            this.button3.Text = "Cancel";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.textBox1.Text = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " (*.txt) | *.txt ";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                  String fname = saveFileDialog1.FileName;
                  File.WriteAllText(fname, f1.textBox1.Text);
                  this.Close();
            }
        }
    }
}
