using System;
using System.Windows.Forms;

namespace WindowsFormsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Kadir";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}