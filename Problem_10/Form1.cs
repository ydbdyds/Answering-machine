using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_10
{
    public partial class Form1 : Form
    {
        int answer;
        int time1 = 11;
        int grade = 0;
        public Form1()
        {
            InitializeComponent();

        }



        private void label1_Click_1(object sender, EventArgs e)
        {


        }



        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            time1 = 10;
            Random ra = new Random(DateTime.Now.Millisecond);
            label2.Text = ra.Next(0, 100).ToString();
            label3.Text = ra.Next(0, 100).ToString();
            int n;
            n = ra.Next(0, 9);
            if (n <= 4)
            {
                symbol.Text = "+";
            }
            else
            {
                symbol.Text = "-";
            }
        }

        private async void 提交_Click(object sender, EventArgs e)
        {
            int tanswer;
            answer = int.Parse(textBox1.Text);
            textBox1.Text = "";
            if (symbol.Text == "+")
            {
                tanswer = int.Parse(label2.Text) + int.Parse(label3.Text);
                if (answer == tanswer)
                {
                    textBox1.BackColor = Color.Green;
                    await Task.Delay(100);
                    textBox1.BackColor = Color.White;
                    grade += 10;
                    goal.Text = grade.ToString();
                    button1_Click(null, null);

                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    await Task.Delay(100);
                    textBox1.BackColor = Color.White;
                    grade -= 5;
                    goal.Text = grade.ToString();
                }
            }
            else
            {
                tanswer = int.Parse(label2.Text) - int.Parse(label3.Text);
                if (answer == tanswer)
                {
                    textBox1.BackColor = Color.Green;
                    await Task.Delay(100);
                    textBox1.BackColor = Color.White;
                    grade += 10;
                    goal.Text = grade.ToString();
                    button1_Click(null, null);

                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    await Task.Delay(100);
                    textBox1.BackColor = Color.White;
                    grade -= 5;
                    goal.Text = grade.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)13)
            {
                提交_Click(null, null);
            }
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)45)

            {

                e.Handled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time1--;
            lad.Text = time1.ToString();

            if (time1 == 0)
            {
                button1_Click(null, null);
                grade -= 10;
                goal.Text = grade.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void goal_Click(object sender, EventArgs e)
        {

        }
    }
}
