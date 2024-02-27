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
        public Form1()
        {
            InitializeComponent();
        }

        enum Operators { None, Add, Sub, Multip, Divide, Result, }

        Operators currentOperators = Operators.None;

        // 오퍼레이트가 바뀌었는지, 현재 오퍼레이트 중인지
        bool operatorsChangeFlag = false;
        
        // 연산결과를 기억하여 SubDisplay에 표시
        int calculatResultsCounter = 0;
        string[] calculatResults = new string[10];

        bool saveValueFlag = false;
        double firstValue = 0;
        double secondValue = 0;
        double answer = 0;

        private void BtnOperator(Operators oper, string str)
        {
            SavedValue(DisplayToDouble(display.Text), str);
            currentOperators = oper;
            operatorsChangeFlag = true;
        }
        private void SavedValue(double Nums, string str)
        {
            CurrentSubDisplay(str);
            if (saveValueFlag)
            {
                secondValue = Nums;
                saveValueFlag = false;
                return;
            }
            firstValue = Nums;
            saveValueFlag = true;
        }
        private void CurrentSubDisplay(string str)
        {
            if (subDisplay.Text == "0")
                subDisplay.Text = display.Text;
            else
                subDisplay.Text += display.Text;
            subDisplay.Text += str;
        }
        private void SavedSubDisplay()
        {

        }
        private void ReturnResult()
        {
            CalculateResult(currentOperators);
            currentOperators = Operators.Result;
        }
        private void CalculateResult(Operators opers)
        {
            SavedValue(DisplayToDouble(display.Text),"=");
            switch (opers)
            {
                case Operators.Add:
                    answer = NumsSum(firstValue, secondValue);
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Sub:
                    answer = NumsSub(firstValue, secondValue);
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Multip:
                    answer = NumsMul(firstValue, secondValue);
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
                case Operators.Divide:
                    if (secondValue == 0)
                    {
                        MessageBox.Show("0으로는 나눌수 없습니다.", "Divide Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    answer = NumsDiv(firstValue, secondValue);
                    display.Text = answer.ToString();
                    currentOperators = Operators.None;
                    break;
            }
            SavedValue(DisplayToDouble(display.Text), "\n");
        }


        // 기능과 관련된 메소드
        private double DisplayToDouble(string str)
        {
            return double.Parse(str);
        }

        // 버튼의 동작과 관련된 메소드
        private void ButtonToDisplay(string strNumber)
        {
            // 사칙연산 버튼을 클릭하면 디스플레이를 지운다.
            if (operatorsChangeFlag)
            {
                display.Text = "0";
                operatorsChangeFlag = false;
            }
            if(currentOperators == Operators.Result)
            {
                DoClean();
                currentOperators = Operators.None;
            }
            display.Text = double.Parse(display.Text += strNumber).ToString();
        }
        // 지우는 기능
        private void DoClean()
        {
            display.Text = "0";
        }
        private void DoAllClean()
        {
            display.Text = "0";
            subDisplay.Text = "0";

            firstValue = 0;
            secondValue = 0;
            currentOperators = Operators.None;

            calculatResultsCounter = 0;
            for(int i = 0; i < calculatResults.Length; i++)
            {
                calculatResults[i] = null;
            }
        }
        private void DoEraser()
        {
            display.Text = display.Text.Substring(0, display.Text.Length - 1);
            if (display.Text.Length < 1)
                display.Text = "0";
        }
        // +/-, 소숫점 기능
        private void DoPlusMinus()
        {
            if (display.Text == "0")
                return;

            double currentNums = double.Parse(display.Text) * -1;
            display.Text = currentNums.ToString();
        }
        private void DoMakeComma()
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

        // 계산과 관련된 메소드
        #region Operation
        public double NumsSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double NumsSub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double NumsMul(double num1, double num2)
        {
            return num1 * num2;
        }
        public double NumsDiv(double num1, double num2)
        {
            return num1 / num2;
        }

        #endregion

        // 버튼 메소드
        #region ButtonTools
        private void Btn_AC(object sender, EventArgs e)
        {
            DoAllClean();
        }
        private void Btn_C(object sender, EventArgs e)
        {
            DoClean();
        }
        private void Btn_Eraser(object sender, EventArgs e)
        {
            DoEraser();
        }
        private void Btn_PM(object sender, EventArgs e)
        {
            DoPlusMinus();
        }
        private void Btn_Com(object sender, EventArgs e)
        {
            DoMakeComma();
        }
        private void Btn_result(object sender, EventArgs e)
        {
            ReturnResult();
        }
        #endregion
        #region ButtonOperator
        private void Btn_Add(object sender, EventArgs e)
        {
            BtnOperator(Operators.Add, "+"); 
        }
        private void Btn_Sub(object sender, EventArgs e)
        {
            BtnOperator(Operators.Sub, "-");
        }
        private void Btn_Mul(object sender, EventArgs e)
        {
            BtnOperator(Operators.Multip, "×"); 
        }
        private void Btn_Div(object sender, EventArgs e)
        {
            BtnOperator(Operators.Divide, "÷"); 
        }
        #endregion
        #region ButtonNumbers
        private void Btn_1(object sender, EventArgs e)
        {
            ButtonToDisplay("1");
        }
        private void Btn_2(object sender, EventArgs e)
        {
            ButtonToDisplay("2");
        }
        private void Btn_3(object sender, EventArgs e)
        {
            ButtonToDisplay("3");
        }
        private void Btn_4(object sender, EventArgs e)
        {
            ButtonToDisplay("4");
        }
        private void Btn_5(object sender, EventArgs e)
        {
            ButtonToDisplay("5");
        }
        private void Btn_6(object sender, EventArgs e)
        {
            ButtonToDisplay("6");
        }
        private void Btn_7(object sender, EventArgs e)
        {
            ButtonToDisplay("7");
        }
        private void Btn_8(object sender, EventArgs e)
        {
            ButtonToDisplay("8");
        }
        private void Btn_9(object sender, EventArgs e)
        {
            ButtonToDisplay("9");
        }
        // 예외 : 최초 숫자(0)일때, 0을 누른경우, 0이 추가되지 않도록 처리
        private void Btn_0(object sender, EventArgs e)
        {
            if (display.Text == "0")
                return;

            ButtonToDisplay("0");
        }
        #endregion

        // 폼과 텍스트 박스에 관련된 메소드
        #region Form and TextBox
        private void Form(object sender, EventArgs e)
        {

        }
        private void MainTextBox(object sender, EventArgs e)
        {

        }
        private void SubTextBox(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
