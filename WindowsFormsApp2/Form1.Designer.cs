namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Answer = new System.Windows.Forms.Button();
            this.Button_Com = new System.Windows.Forms.Button();
            this.Button_0 = new System.Windows.Forms.Button();
            this.Button_PM = new System.Windows.Forms.Button();
            this.Button_Div = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_Mul = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_Sub = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Era = new System.Windows.Forms.Button();
            this.Button_CE = new System.Windows.Forms.Button();
            this.Button_AC = new System.Windows.Forms.Button();
            this.subDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(11, 254);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(454, 52);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display.Click += new System.EventHandler(this.MainTextBox);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Button_Answer, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button_Com, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button_PM, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button_Div, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button_Mul, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_Sub, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_Add, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_Era, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_CE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_AC, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 324);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Button_Answer
            // 
            this.Button_Answer.AutoSize = true;
            this.Button_Answer.Location = new System.Drawing.Point(342, 259);
            this.Button_Answer.Name = "Button_Answer";
            this.Button_Answer.Size = new System.Drawing.Size(107, 60);
            this.Button_Answer.TabIndex = 19;
            this.Button_Answer.Text = "=";
            this.Button_Answer.UseVisualStyleBackColor = true;
            this.Button_Answer.Click += new System.EventHandler(this.Btn_result);
            // 
            // Button_Com
            // 
            this.Button_Com.Location = new System.Drawing.Point(229, 259);
            this.Button_Com.Name = "Button_Com";
            this.Button_Com.Size = new System.Drawing.Size(107, 60);
            this.Button_Com.TabIndex = 18;
            this.Button_Com.Text = ".";
            this.Button_Com.UseVisualStyleBackColor = true;
            this.Button_Com.Click += new System.EventHandler(this.Btn_Com);
            // 
            // Button_0
            // 
            this.Button_0.Location = new System.Drawing.Point(116, 259);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(107, 60);
            this.Button_0.TabIndex = 17;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = true;
            this.Button_0.Click += new System.EventHandler(this.Btn_0);
            // 
            // Button_PM
            // 
            this.Button_PM.Location = new System.Drawing.Point(3, 259);
            this.Button_PM.Name = "Button_PM";
            this.Button_PM.Size = new System.Drawing.Size(107, 60);
            this.Button_PM.TabIndex = 16;
            this.Button_PM.Text = "+/-";
            this.Button_PM.UseVisualStyleBackColor = true;
            this.Button_PM.Click += new System.EventHandler(this.Btn_PM);
            // 
            // Button_Div
            // 
            this.Button_Div.Location = new System.Drawing.Point(342, 195);
            this.Button_Div.Name = "Button_Div";
            this.Button_Div.Size = new System.Drawing.Size(107, 58);
            this.Button_Div.TabIndex = 15;
            this.Button_Div.Text = "÷";
            this.Button_Div.UseVisualStyleBackColor = true;
            this.Button_Div.Click += new System.EventHandler(this.Btn_Div);
            // 
            // Button_3
            // 
            this.Button_3.Location = new System.Drawing.Point(229, 195);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(107, 58);
            this.Button_3.TabIndex = 14;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = true;
            this.Button_3.Click += new System.EventHandler(this.Btn_3);
            // 
            // Button_2
            // 
            this.Button_2.Location = new System.Drawing.Point(116, 195);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(107, 58);
            this.Button_2.TabIndex = 13;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Btn_2);
            // 
            // Button_1
            // 
            this.Button_1.Location = new System.Drawing.Point(3, 195);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(107, 58);
            this.Button_1.TabIndex = 12;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Btn_1);
            // 
            // Button_Mul
            // 
            this.Button_Mul.Location = new System.Drawing.Point(342, 131);
            this.Button_Mul.Name = "Button_Mul";
            this.Button_Mul.Size = new System.Drawing.Size(107, 58);
            this.Button_Mul.TabIndex = 11;
            this.Button_Mul.Text = "×";
            this.Button_Mul.UseVisualStyleBackColor = true;
            this.Button_Mul.Click += new System.EventHandler(this.Btn_Mul);
            // 
            // Button_6
            // 
            this.Button_6.Location = new System.Drawing.Point(229, 131);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(107, 58);
            this.Button_6.TabIndex = 10;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Btn_6);
            // 
            // Button_5
            // 
            this.Button_5.Location = new System.Drawing.Point(116, 131);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(107, 58);
            this.Button_5.TabIndex = 9;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = true;
            this.Button_5.Click += new System.EventHandler(this.Btn_5);
            // 
            // Button_4
            // 
            this.Button_4.Location = new System.Drawing.Point(3, 131);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(107, 58);
            this.Button_4.TabIndex = 8;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = true;
            this.Button_4.Click += new System.EventHandler(this.Btn_4);
            // 
            // Button_Sub
            // 
            this.Button_Sub.Location = new System.Drawing.Point(342, 67);
            this.Button_Sub.Name = "Button_Sub";
            this.Button_Sub.Size = new System.Drawing.Size(107, 58);
            this.Button_Sub.TabIndex = 7;
            this.Button_Sub.Text = "-";
            this.Button_Sub.UseVisualStyleBackColor = true;
            this.Button_Sub.Click += new System.EventHandler(this.Btn_Sub);
            // 
            // Button_9
            // 
            this.Button_9.Location = new System.Drawing.Point(229, 67);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(107, 58);
            this.Button_9.TabIndex = 6;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = true;
            this.Button_9.Click += new System.EventHandler(this.Btn_9);
            // 
            // Button_8
            // 
            this.Button_8.Location = new System.Drawing.Point(116, 67);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(107, 58);
            this.Button_8.TabIndex = 5;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = true;
            this.Button_8.Click += new System.EventHandler(this.Btn_8);
            // 
            // Button_7
            // 
            this.Button_7.Location = new System.Drawing.Point(3, 67);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(107, 58);
            this.Button_7.TabIndex = 4;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = true;
            this.Button_7.Click += new System.EventHandler(this.Btn_7);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(342, 3);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(107, 58);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "+";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Btn_Add);
            // 
            // Button_Era
            // 
            this.Button_Era.Location = new System.Drawing.Point(229, 3);
            this.Button_Era.Name = "Button_Era";
            this.Button_Era.Size = new System.Drawing.Size(107, 58);
            this.Button_Era.TabIndex = 2;
            this.Button_Era.Text = "←";
            this.Button_Era.UseVisualStyleBackColor = true;
            this.Button_Era.Click += new System.EventHandler(this.Btn_Eraser);
            // 
            // Button_CE
            // 
            this.Button_CE.Location = new System.Drawing.Point(116, 3);
            this.Button_CE.Name = "Button_CE";
            this.Button_CE.Size = new System.Drawing.Size(107, 58);
            this.Button_CE.TabIndex = 1;
            this.Button_CE.Text = "CE";
            this.Button_CE.UseVisualStyleBackColor = true;
            this.Button_CE.Click += new System.EventHandler(this.Btn_C);
            // 
            // Button_AC
            // 
            this.Button_AC.Location = new System.Drawing.Point(3, 3);
            this.Button_AC.Name = "Button_AC";
            this.Button_AC.Size = new System.Drawing.Size(107, 58);
            this.Button_AC.TabIndex = 0;
            this.Button_AC.Text = "AC";
            this.Button_AC.UseVisualStyleBackColor = true;
            this.Button_AC.Click += new System.EventHandler(this.Btn_AC);
            // 
            // subDisplay
            // 
            this.subDisplay.BackColor = System.Drawing.Color.White;
            this.subDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subDisplay.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subDisplay.Location = new System.Drawing.Point(11, 14);
            this.subDisplay.Name = "subDisplay";
            this.subDisplay.Size = new System.Drawing.Size(454, 240);
            this.subDisplay.TabIndex = 3;
            this.subDisplay.Text = "0";
            this.subDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.subDisplay.Click += new System.EventHandler(this.SubTextBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 644);
            this.Controls.Add(this.subDisplay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Button_Answer;
        private System.Windows.Forms.Button Button_Com;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button Button_PM;
        private System.Windows.Forms.Button Button_Div;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_Mul;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_Sub;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Era;
        private System.Windows.Forms.Button Button_CE;
        private System.Windows.Forms.Button Button_AC;
        private System.Windows.Forms.Label subDisplay;
    }
}

