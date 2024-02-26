using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        enum Operators { None, Add, Sub, Multip, Divide, Result, }
        Operators currentOperators = Operators.None;

        bool operatorsChangeFlag = false;

        double firstValue = 0;
        double secondValue = 0;
        double answer = 0;
        

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
            firstValue = 0;
            secondValue = 0;
            display.Text = "0";
            answer = 0;
            currentOperators = Operators.None;
        }
        private void Btn_C(object sender, EventArgs e)
        {

        }
        private void Btn_Eraser(object sender, EventArgs e)
        {
            //char[] lastText = MainText.Text.ToCharArray();
            //char[] currentText = null;
            //for(int i = 0; i < lastText.Length - 2; i++)
            //    currentText[i] = lastText[i];
            //MainText.Text = currentText.ToString();
        }

        private void BtnOperator(Operators oper)
        {
            firstValue = Int32.Parse(display.Text);
            currentOperators = oper;
            operatorsChangeFlag = true;
        }

        private void Btn_result(object sender, EventArgs e)
        {
            secondValue = Int32.Parse(display.Text);
            switch (currentOperators)
            {
                case Operators.Add:
                    answer = firstValue + secondValue;
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Sub:
                    answer = firstValue - secondValue;
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Multip:
                    answer = firstValue * secondValue;
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Divide:
                    answer = firstValue / secondValue;
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;

                    break;
            }
        }

        private void ReturnStringToDouble(string strNumber)
        {
            if (operatorsChangeFlag)
            {
                display.Text = "";
                operatorsChangeFlag = false;
            }
            string strNumbers = display.Text += strNumber;
            display.Text = double.Parse(strNumbers).ToString();
        }

        private void Btn_Add(object sender, EventArgs e)
        {
            BtnOperator(Operators.Add); 
        }
        private void Btn_Sub(object sender, EventArgs e)
        {
            BtnOperator(Operators.Sub);
        }
        private void Btn_Mul(object sender, EventArgs e)
        {
            BtnOperator(Operators.Multip); 
        }
        private void Btn_Div(object sender, EventArgs e)
        {
            BtnOperator(Operators.Divide); 
        }

        private void Btn_PM(object sender, EventArgs e)
        {

        }
        private void Btn_Com(object sender, EventArgs e)
        {
            if (display.Text.Contains("."))
            {
                return;
            }
            else
            {
                display.Text += ".";
            }
        }

        #region ButtonNumbers
        private void Btn_1(object sender, EventArgs e)
        {
            ReturnStringToDouble("1");
        }
        private void Btn_2(object sender, EventArgs e)
        {
            ReturnStringToDouble("2");
        }
        private void Btn_3(object sender, EventArgs e)
        {
            ReturnStringToDouble("3");
        }
        private void Btn_4(object sender, EventArgs e)
        {
            ReturnStringToDouble("4");
        }
        private void Btn_5(object sender, EventArgs e)
        {
            ReturnStringToDouble("5");
        }
        private void Btn_6(object sender, EventArgs e)
        {
            ReturnStringToDouble("6");
        }
        private void Btn_7(object sender, EventArgs e)
        {
            ReturnStringToDouble("7");
        }
        private void Btn_8(object sender, EventArgs e)
        {
            ReturnStringToDouble("8");
        }
        private void Btn_9(object sender, EventArgs e)
        {
            ReturnStringToDouble("9");
        }
        private void Btn_0(object sender, EventArgs e)
        {
            ReturnStringToDouble("0");
        }
        #endregion
    }
}
