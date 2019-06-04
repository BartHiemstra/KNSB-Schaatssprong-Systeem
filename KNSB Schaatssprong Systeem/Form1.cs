using System;
using System.Windows.Forms;

namespace KNSB_Schaatssprong_Systeem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "Doei");
        }
    }
}