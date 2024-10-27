using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 curform = new Form4();
            Form1 form = new Form1();
            form.Show();
            curform.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 curform = new Form4();
            Form2 form = new Form2();
            form.Show();
            curform.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 My_Form = new Form1();
            My_Form.Show();
            this.Close();
        }
    }
}
