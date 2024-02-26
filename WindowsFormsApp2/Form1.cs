using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        enum Operators
        {
            Result,
            Add,
            Sub,
            Multip,
            Divide,
            None,
        }
        Operators currentOperators = Operators.None;
        bool isOperatorsChange = false;
        int firstOper = 0;
        int secondOper = 0;
        int answer = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form(object sender, EventArgs e)
        {

        }
        private void MainTextBox(object sender, EventArgs e)
        {

        }


        private void Btn_AC(object sender, EventArgs e)
        {
            firstOper = 0;
            secondOper = 0;
            answer = 0;
            currentOperators = Operators.None;
            label1.Text = "";
        }
        private void Btn_C(object sender, EventArgs e)
        {
            switch (isOperatorsChange)
            {
                case false:
                    firstOper = 0;
                    break;
                case true:
                    secondOper = 0;
                    break;
            }
        }

        private void Btn_Result(object sender, EventArgs e)
        {
            secondOper = Int32.Parse(label1.Text);
            switch (currentOperators)
            {
                case Operators.Add:
                    answer = firstOper + secondOper;
                    label1.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Sub:
                    answer = firstOper - secondOper;
                    label1.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Multip:
                    answer = firstOper * secondOper;
                    label1.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Divide:
                    answer = firstOper / secondOper;
                    label1.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
            }
        }
        private void BtnOper(Operators oper)
        {
            firstOper = Int32.Parse(label1.Text);
            currentOperators = oper;
            isOperatorsChange = true;
        }
        private void BtnNumber(string btnNum)
        {
            if (isOperatorsChange)
            {
                label1.Text = "";
                isOperatorsChange = false;
            }

            string strNumber = label1.Text += btnNum;
            int intNumber = int.Parse(strNumber);
            label1.Text = intNumber.ToString();
        }

        private void Btn_Add(object sender, EventArgs e)
        {
            BtnOper(Operators.Add);
        }
        private void Btn_sub(object sender, EventArgs e)
        {
            BtnOper(Operators.Sub);
        }
        private void Btn_Mul(object sender, EventArgs e)
        {
            BtnOper(Operators.Multip);
        }
        private void Btn_Div(object sender, EventArgs e)
        {
            BtnOper(Operators.Divide);
        }

        private void Btn_1(object sender, EventArgs e)
        {
            BtnNumber("1");
        }
        private void Btn_2(object sender, EventArgs e)
        {
            BtnNumber("2");
        }
        private void Btn_3(object sender, EventArgs e)
        {
            BtnNumber("3");
        }
        private void Btn_4(object sender, EventArgs e)
        {
            BtnNumber("4");
        }
        private void Btn_5(object sender, EventArgs e)
        {
            BtnNumber("5");
        }
        private void Btn_6(object sender, EventArgs e)
        {
            BtnNumber("6");
        }
        private void Btn_7(object sender, EventArgs e)
        {
            BtnNumber("7");
        }
        private void Btn_8(object sender, EventArgs e)
        {
            BtnNumber("8");
        }
        private void Btn_9(object sender, EventArgs e)
        {
            BtnNumber("9");
        }
        private void Btn_0(object sender, EventArgs e)
        {
            BtnNumber("0");
        }

    }
}
