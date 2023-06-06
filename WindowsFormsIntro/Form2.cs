using System;
using System.Windows.Forms;

namespace WindowsFormsIntro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + "" + maskedTextBox2.Text + "" + maskedTextBox3.Text + "" +
                               maskedTextBox4);
        }
    }
}