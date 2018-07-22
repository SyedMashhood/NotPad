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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label1.Text = "Find what";
            this.button1.Text = "Find";
            this.button2.Text = "Cancel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("Find Successful ");
            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }
    }
}
