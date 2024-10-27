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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.представленияTableAdapter1.Fill(this.allaDataSet.Представления);
           dataGridView1.Visible= true;
            dataGridView2.Visible= false;
            dataGridView3.Visible= false;
            dataGridView4.Visible= false;
            dataGridView5.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.программа_циркаTableAdapter1.Fill(this.allaDataSet.Программа_цирка);
            dataGridView1.Visible= false;
            dataGridView2.Visible= true;
            dataGridView3.Visible= false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.работники_циркаTableAdapter1.Fill(this.allaDataSet.Работники_цирка);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.расписание_гастролейTableAdapter1.Fill(this.allaDataSet.Расписание_гастролей);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.труппа_представления_циркаTableAdapter1.Fill(this.allaDataSet.Труппа_представления_цирка);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            представленияTableAdapter1.Update(allaDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            программа_циркаTableAdapter1.Update(allaDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            работники_циркаTableAdapter1.Update(allaDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            расписание_гастролейTableAdapter1.Update(allaDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            труппа_представления_циркаTableAdapter1.Update(allaDataSet);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
            {
                представленияBindingSource.Filter = textBox1.Text;
                представленияBindingSource.Sort = textBox2.Text;
            }
            else if (dataGridView2.Visible)
            {
                программаЦиркаBindingSource.Filter = textBox1.Text;
                программаЦиркаBindingSource.Sort = textBox2.Text;
            }
            else if (dataGridView3.Visible)
            {
                работникиЦиркаBindingSource.Filter = textBox1.Text;
                работникиЦиркаBindingSource.Sort = textBox2.Text;
            }
            else if (dataGridView4.Visible)
            {
                расписаниеГастролейBindingSource.Filter = textBox1.Text;
                расписаниеГастролейBindingSource.Sort = textBox2.Text;
            }
            else if (dataGridView5.Visible) {
                труппаПредставленияЦиркаBindingSource.Filter = textBox1.Text;
                труппаПредставленияЦиркаBindingSource.Sort = textBox2.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 curform = new Form1();
            Form3 form = new Form3();
            form.Show();
            curform.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
