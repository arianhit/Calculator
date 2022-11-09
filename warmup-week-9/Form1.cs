using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warmup_week_9
{

    public partial class Form1 : Form
    {
        float Total = 0;
        int firstNumber;
        bool FirstNumber = true;
        bool SecondNumber = false;
        int Action = 0;
        int i = 0;
        Number n = new Number();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(1);
                firstNumber = 1;
            }
            else if (SecondNumber == true)
            {
                n.NextNum = 1;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(2);
                firstNumber = 2;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 2;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(3);
                firstNumber = 3;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 3;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                enalbeActionButtons();

                disableNumButtons();
                calculation();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(4);
                firstNumber = 4;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 4;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(5);
                firstNumber = 5;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 5;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(6);
                firstNumber = 6;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 6;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(7);
                firstNumber = 7;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 7;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(8);
                firstNumber = 8;

            }
            else if (SecondNumber == true)
            {
                n.NextNum = 8;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(9);
                firstNumber = 9;
            }
            else if (SecondNumber == true)
            {

                n.NextNum = 9;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (FirstNumber == true)
            {
                lblCurNum.Text = Convert.ToString(0);
                firstNumber = 0;
            }
            else if (SecondNumber == true)
            {

                n.NextNum = 0;
                lblCurNum.Text = lblCurNum.Text + Convert.ToString(n.NextNum);
                disableNumButtons();
                enalbeActionButtons();
                calculation();

            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            disableActionButtons();
            enableNumButtons();

            FirstNumber = false;
            SecondNumber = true;
            Action = 1;
            lblCurNum.Text = lblCurNum.Text + " + ";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            disableActionButtons();
            enableNumButtons();
            Action = 2;

            FirstNumber = false;
            SecondNumber = true;
            lblCurNum.Text = lblCurNum.Text + " x ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            disableActionButtons();
            enableNumButtons();
            Action = 3;

            FirstNumber = false;
            SecondNumber = true;


            lblCurNum.Text = lblCurNum.Text + " ÷ ";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            disableActionButtons();
            enableNumButtons();

            FirstNumber = false;
            SecondNumber = true;
            Action = 4;

            lblCurNum.Text = lblCurNum.Text + " - ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            disableActionButtons();
            FirstNumber = false;
            SecondNumber = false;


            lblCurNum.Text = lblCurNum.Text + " = " + Total;
            i++;
            lbAnwsers.Items.Add(lblCurNum.Text).ToString();
            
            
        }
        private void disableNumButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button0.Enabled = false;

        }
        private void disableActionButtons()
        {
            btnEqual.Enabled = false;
            btnPlus.Enabled = false;
            btnMin.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
        }
        private void enableNumButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button0.Enabled = true;
        }
        private void enalbeActionButtons()
        {
            btnEqual.Enabled = true;
            btnPlus.Enabled = true;
            btnMin.Enabled = true;
            btnMult.Enabled = true;
            btnDiv.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            enableNumButtons();
            enalbeActionButtons();
            lblCurNum.Text = " ";
            Total = 0;
            FirstNumber = true;
            SecondNumber = false;
            firstNumber = 0;
            n.NextNum = 0;
        }
        private void calculation()
        {
            switch (Action)
            {
                case 1:
                    if (Total == 0)
                    {

                        Total = firstNumber + n.NextNum;
                    }
                    else
                    {
                        Total = Total + n.NextNum;
                    }
                    break;
                case 2:
                    if (Total == 0)
                    {
                        Total = firstNumber * n.NextNum;
                    }
                    else
                    {
                        Total = Total * n.NextNum;
                    }

                    break;
                case 3:
                    if (Total == 0)
                    {
                        Total = firstNumber / n.NextNum;
                    }
                    else
                    {
                        Total = Total / n.NextNum;
                    }
                    break;
                case 4:
                    if (Total == 0)
                    {
                        Total = firstNumber - n.NextNum;
                    }
                    else
                    {
                        Total = Total - n.NextNum;
                    }

                    break;
            }
            
            

        }
        class Number
        {
            public int NextNum;
        }

        
    }
}
