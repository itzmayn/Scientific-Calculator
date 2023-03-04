namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAddition = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMultiply = new Button();
            btnPowerOf = new Button();
            btnSqrt = new Button();
            btnPercentOf = new Button();
            btnDecimal = new Button();
            btnBackspace = new Button();
            ongoingOperationDisplay = new Label();
            inputDisplayBox = new TextBox();
            btnEquals = new Button();
            btnClearAll = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.ForeColor = Color.Crimson;
            btn1.Location = new Point(12, 367);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 45);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.ForeColor = Color.Crimson;
            btn2.Location = new Point(94, 367);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.ForeColor = Color.Crimson;
            btn3.Location = new Point(175, 367);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 45);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btnAddition
            // 
            btnAddition.ForeColor = Color.Crimson;
            btnAddition.Location = new Point(256, 299);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(65, 45);
            btnAddition.TabIndex = 3;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += operator_Click;
            // 
            // btnMinus
            // 
            btnMinus.ForeColor = Color.Crimson;
            btnMinus.Location = new Point(256, 234);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 45);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operator_Click;
            // 
            // btn6
            // 
            btn6.ForeColor = Color.Crimson;
            btn6.Location = new Point(175, 302);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 45);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.ForeColor = Color.Crimson;
            btn5.Location = new Point(94, 302);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 45);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.ForeColor = Color.Crimson;
            btn4.Location = new Point(12, 302);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 45);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btnDivide
            // 
            btnDivide.ForeColor = Color.Crimson;
            btnDivide.Location = new Point(256, 169);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(65, 45);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += operator_Click;
            // 
            // btn9
            // 
            btn9.ForeColor = Color.Crimson;
            btn9.Location = new Point(175, 237);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.ForeColor = Color.Crimson;
            btn8.Location = new Point(94, 237);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 45);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.ForeColor = Color.Crimson;
            btn7.Location = new Point(12, 237);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.ForeColor = Color.Crimson;
            btnMultiply.Location = new Point(256, 99);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(65, 45);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += operator_Click;
            // 
            // btnPowerOf
            // 
            btnPowerOf.ForeColor = Color.Crimson;
            btnPowerOf.Location = new Point(94, 167);
            btnPowerOf.Name = "btnPowerOf";
            btnPowerOf.Size = new Size(65, 45);
            btnPowerOf.TabIndex = 14;
            btnPowerOf.Text = "Pow";
            btnPowerOf.UseVisualStyleBackColor = true;
            btnPowerOf.Click += operator_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.ForeColor = Color.Crimson;
            btnSqrt.Location = new Point(12, 167);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(65, 45);
            btnSqrt.TabIndex = 13;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += operator_Click;
            // 
            // btnPercentOf
            // 
            btnPercentOf.ForeColor = Color.Crimson;
            btnPercentOf.Location = new Point(175, 167);
            btnPercentOf.Name = "btnPercentOf";
            btnPercentOf.Size = new Size(65, 45);
            btnPercentOf.TabIndex = 12;
            btnPercentOf.Text = "%";
            btnPercentOf.UseVisualStyleBackColor = true;
            btnPercentOf.Click += operator_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.ForeColor = Color.Crimson;
            btnDecimal.Location = new Point(175, 421);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(65, 45);
            btnDecimal.TabIndex = 19;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnNum_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.ForeColor = Color.Crimson;
            btnBackspace.Location = new Point(175, 99);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(65, 45);
            btnBackspace.TabIndex = 17;
            btnBackspace.Text = "C";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // ongoingOperationDisplay
            // 
            ongoingOperationDisplay.AutoSize = true;
            ongoingOperationDisplay.Location = new Point(12, 9);
            ongoingOperationDisplay.Name = "ongoingOperationDisplay";
            ongoingOperationDisplay.Size = new Size(76, 23);
            ongoingOperationDisplay.TabIndex = 20;
            ongoingOperationDisplay.Text = "label1";
            // 
            // inputDisplayBox
            // 
            inputDisplayBox.Location = new Point(12, 46);
            inputDisplayBox.Name = "inputDisplayBox";
            inputDisplayBox.Size = new Size(309, 31);
            inputDisplayBox.TabIndex = 21;
            inputDisplayBox.Text = "0";
            inputDisplayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEquals
            // 
            btnEquals.ForeColor = Color.Crimson;
            btnEquals.Location = new Point(256, 367);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(65, 96);
            btnEquals.TabIndex = 22;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += equatTo_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.ForeColor = Color.Crimson;
            btnClearAll.Location = new Point(12, 99);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(147, 45);
            btnClearAll.TabIndex = 23;
            btnClearAll.Text = "CE";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btn0
            // 
            btn0.ForeColor = Color.Crimson;
            btn0.Location = new Point(12, 421);
            btn0.Name = "btn0";
            btn0.Size = new Size(147, 45);
            btn0.TabIndex = 24;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 478);
            Controls.Add(btn0);
            Controls.Add(btnClearAll);
            Controls.Add(btnEquals);
            Controls.Add(inputDisplayBox);
            Controls.Add(ongoingOperationDisplay);
            Controls.Add(btnDecimal);
            Controls.Add(btnBackspace);
            Controls.Add(btnMultiply);
            Controls.Add(btnPowerOf);
            Controls.Add(btnSqrt);
            Controls.Add(btnPercentOf);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAddition);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAddition;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMultiply;
        private Button btnPowerOf;
        private Button btnSqrt;
        private Button btnPercentOf;
        private Button btnDecimal;
        private Button btnBackspace;
        private Label ongoingOperationDisplay;
        private TextBox inputDisplayBox;
        private Button btnEquals;
        private Button btnClearAll;
        private Button btn0;
    }
}