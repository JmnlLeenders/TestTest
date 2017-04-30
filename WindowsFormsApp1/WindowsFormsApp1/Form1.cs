using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int _labelClicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _labelClicked++;
            label1.Text = String.Format("Hello World! clicked {0} times.", _labelClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
