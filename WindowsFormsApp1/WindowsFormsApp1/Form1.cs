using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int _labelClicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _labelClicked++;
            label1.Text = $"Hello World! clicked {_labelClicked} times.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
