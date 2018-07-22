using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Source String";
            this.label2.Text = "Change String";
            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            f1.textBox1.Text = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            MessageBox.Show("Replaced " + this.textBox1.Text+" to "+this.textBox2.Text);
            this.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
