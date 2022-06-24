namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.buttonSubstr = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMulty = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonOpenSquareBracket = new System.Windows.Forms.Button();
            this.buttonCloseSquareBracket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(274, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 75);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(17, 16);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(785, 39);
            this.outputTextBox.TabIndex = 1;
            // 
            // buttonSubstr
            // 
            this.buttonSubstr.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubstr.Location = new System.Drawing.Point(183, 69);
            this.buttonSubstr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSubstr.Name = "buttonSubstr";
            this.buttonSubstr.Size = new System.Drawing.Size(75, 75);
            this.buttonSubstr.TabIndex = 2;
            this.buttonSubstr.Text = "-";
            this.buttonSubstr.UseVisualStyleBackColor = true;
            this.buttonSubstr.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.Location = new System.Drawing.Point(183, 158);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 75);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new System.Drawing.Point(17, 69);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(150, 75);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonMulty
            // 
            this.buttonMulty.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulty.Location = new System.Drawing.Point(274, 158);
            this.buttonMulty.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonMulty.Name = "buttonMulty";
            this.buttonMulty.Size = new System.Drawing.Size(75, 75);
            this.buttonMulty.TabIndex = 4;
            this.buttonMulty.Text = "*";
            this.buttonMulty.UseVisualStyleBackColor = true;
            this.buttonMulty.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.Location = new System.Drawing.Point(727, 69);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 75);
            this.buttonEquals.TabIndex = 5;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new System.Drawing.Point(17, 158);
            this.buttonMax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(150, 75);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new System.Drawing.Point(17, 247);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(150, 75);
            this.buttonCos.TabIndex = 7;
            this.buttonCos.Text = "Cos";
            this.buttonCos.UseVisualStyleBackColor = true;
            this.buttonCos.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new System.Drawing.Point(17, 336);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(150, 75);
            this.buttonSin.TabIndex = 8;
            this.buttonSin.Text = "Sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPow.Location = new System.Drawing.Point(274, 247);
            this.buttonPow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(75, 75);
            this.buttonPow.TabIndex = 9;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(638, 158);
            this.buttonC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 75);
            this.buttonC.TabIndex = 10;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.Location = new System.Drawing.Point(638, 69);
            this.buttonBackspace.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(75, 75);
            this.buttonBackspace.TabIndex = 11;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistory.Location = new System.Drawing.Point(638, 336);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(166, 75);
            this.buttonHistory.TabIndex = 12;
            this.buttonHistory.Text = "История";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.Location = new System.Drawing.Point(456, 336);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 75);
            this.buttonZero.TabIndex = 13;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(365, 69);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 75);
            this.buttonOne.TabIndex = 14;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(456, 69);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 75);
            this.buttonTwo.TabIndex = 15;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.Location = new System.Drawing.Point(547, 69);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(75, 75);
            this.buttonThree.TabIndex = 16;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.Location = new System.Drawing.Point(365, 158);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(75, 75);
            this.buttonFour.TabIndex = 17;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.Location = new System.Drawing.Point(456, 158);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(75, 75);
            this.buttonFive.TabIndex = 18;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.Location = new System.Drawing.Point(547, 158);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(75, 75);
            this.buttonSix.TabIndex = 19;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.Location = new System.Drawing.Point(365, 247);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(75, 75);
            this.buttonSeven.TabIndex = 20;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.Location = new System.Drawing.Point(456, 247);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(75, 75);
            this.buttonEight.TabIndex = 21;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.Location = new System.Drawing.Point(547, 247);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(75, 75);
            this.buttonNine.TabIndex = 22;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenBracket.Location = new System.Drawing.Point(365, 336);
            this.buttonOpenBracket.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(75, 75);
            this.buttonOpenBracket.TabIndex = 23;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            this.buttonOpenBracket.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseBracket.Location = new System.Drawing.Point(547, 336);
            this.buttonCloseBracket.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(75, 75);
            this.buttonCloseBracket.TabIndex = 24;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = true;
            this.buttonCloseBracket.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.Location = new System.Drawing.Point(274, 336);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 75);
            this.buttonPoint.TabIndex = 25;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComma.Location = new System.Drawing.Point(183, 336);
            this.buttonComma.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(75, 75);
            this.buttonComma.TabIndex = 26;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFactorial.Location = new System.Drawing.Point(183, 247);
            this.buttonFactorial.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(75, 75);
            this.buttonFactorial.TabIndex = 27;
            this.buttonFactorial.Text = "!";
            this.buttonFactorial.UseVisualStyleBackColor = true;
            this.buttonFactorial.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonOpenSquareBracket
            // 
            this.buttonOpenSquareBracket.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSquareBracket.Location = new System.Drawing.Point(638, 247);
            this.buttonOpenSquareBracket.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOpenSquareBracket.Name = "buttonOpenSquareBracket";
            this.buttonOpenSquareBracket.Size = new System.Drawing.Size(75, 75);
            this.buttonOpenSquareBracket.TabIndex = 28;
            this.buttonOpenSquareBracket.Text = "[";
            this.buttonOpenSquareBracket.UseVisualStyleBackColor = true;
            this.buttonOpenSquareBracket.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonCloseSquareBracket
            // 
            this.buttonCloseSquareBracket.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseSquareBracket.Location = new System.Drawing.Point(727, 247);
            this.buttonCloseSquareBracket.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCloseSquareBracket.Name = "buttonCloseSquareBracket";
            this.buttonCloseSquareBracket.Size = new System.Drawing.Size(75, 75);
            this.buttonCloseSquareBracket.TabIndex = 29;
            this.buttonCloseSquareBracket.Text = "]";
            this.buttonCloseSquareBracket.UseVisualStyleBackColor = true;
            this.buttonCloseSquareBracket.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 423);
            this.Controls.Add(this.buttonCloseSquareBracket);
            this.Controls.Add(this.buttonOpenSquareBracket);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonCloseBracket);
            this.Controls.Add(this.buttonOpenBracket);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonMulty);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonSubstr);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button buttonSubstr;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMulty;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonOpenSquareBracket;
        private System.Windows.Forms.Button buttonCloseSquareBracket;
    }
}

