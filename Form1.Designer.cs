namespace AppCalculadora
{
    partial class Form1
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
            textResultado = new TextBox();
            buttonDecimal = new Button();
            button0 = new Button();
            buttonSigno = new Button();
            buttonIgual = new Button();
            buttonRes = new Button();
            buttoSum = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            buttonBorrar = new Button();
            buttonC = new Button();
            buttonCE = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textResultado
            // 
            textResultado.BackColor = SystemColors.ControlLightLight;
            textResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textResultado.Location = new Point(12, 12);
            textResultado.MaxLength = 15;
            textResultado.Multiline = true;
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(213, 42);
            textResultado.TabIndex = 0;
            textResultado.Text = "0";
            textResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimal.Location = new Point(114, 280);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(45, 45);
            buttonDecimal.TabIndex = 49;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(63, 280);
            button0.Name = "button0";
            button0.Size = new Size(45, 45);
            button0.TabIndex = 48;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += agregarNumero;
            // 
            // buttonSigno
            // 
            buttonSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSigno.Location = new Point(12, 280);
            buttonSigno.Name = "buttonSigno";
            buttonSigno.Size = new Size(45, 45);
            buttonSigno.TabIndex = 47;
            buttonSigno.Text = "+/-";
            buttonSigno.UseVisualStyleBackColor = true;
            buttonSigno.Click += buttonSigno_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.Location = new Point(180, 280);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(45, 45);
            buttonIgual.TabIndex = 46;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonRes
            // 
            buttonRes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRes.Location = new Point(180, 178);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(45, 45);
            buttonRes.TabIndex = 45;
            buttonRes.Tag = "-";
            buttonRes.Text = "-";
            buttonRes.UseVisualStyleBackColor = true;
            buttonRes.Click += operacion;
            // 
            // buttoSum
            // 
            buttoSum.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttoSum.Location = new Point(180, 229);
            buttoSum.Name = "buttoSum";
            buttoSum.Size = new Size(45, 45);
            buttoSum.TabIndex = 44;
            buttoSum.Tag = "+";
            buttoSum.Text = "+";
            buttoSum.UseVisualStyleBackColor = true;
            buttoSum.Click += operacion;
            // 
            // buttonMult
            // 
            buttonMult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMult.Location = new Point(180, 127);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(45, 45);
            buttonMult.TabIndex = 43;
            buttonMult.Tag = "*";
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += operacion;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDiv.Location = new Point(180, 76);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(45, 45);
            buttonDiv.TabIndex = 42;
            buttonDiv.Tag = "/";
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += operacion;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBorrar.Location = new Point(114, 76);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(45, 45);
            buttonBorrar.TabIndex = 41;
            buttonBorrar.Text = "<--";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonC.Location = new Point(63, 76);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(45, 45);
            buttonC.TabIndex = 40;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCE.Location = new Point(12, 76);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(45, 45);
            buttonCE.TabIndex = 39;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(114, 127);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 38;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += agregarNumero;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(63, 127);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 37;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += agregarNumero;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 127);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 36;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += agregarNumero;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(114, 178);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 35;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += agregarNumero;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(63, 178);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 34;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += agregarNumero;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 178);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 33;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += agregarNumero;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(114, 229);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 32;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += agregarNumero;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(63, 229);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 31;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += agregarNumero;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 229);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 30;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += agregarNumero;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 335);
            Controls.Add(buttonDecimal);
            Controls.Add(button0);
            Controls.Add(buttonSigno);
            Controls.Add(buttonIgual);
            Controls.Add(buttonRes);
            Controls.Add(buttoSum);
            Controls.Add(buttonMult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textResultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppCalculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResultado;
        private Button buttonDecimal;
        private Button button0;
        private Button buttonSigno;
        private Button buttonIgual;
        private Button buttonRes;
        private Button buttoSum;
        private Button buttonMult;
        private Button buttonDiv;
        private Button buttonBorrar;
        private Button buttonC;
        private Button buttonCE;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}