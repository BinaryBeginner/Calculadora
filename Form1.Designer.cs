namespace Calculadora
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
            Pantalla = new TextBox();
            btn1 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btneliminar = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btndivision = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnmultiplicar = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnresta = new Button();
            btnsuma = new Button();
            btnraiz = new Button();
            btnigual = new Button();
            btn0 = new Button();
            btnpunto = new Button();
            SuspendLayout();
            // 
            // Pantalla
            // 
            Pantalla.Location = new Point(25, 25);
            Pantalla.Name = "Pantalla";
            Pantalla.ReadOnly = true;
            Pantalla.Size = new Size(278, 23);
            Pantalla.TabIndex = 0;
            Pantalla.TextAlign = HorizontalAlignment.Right;
            Pantalla.TextChanged += Pantalla_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(25, 240);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 48);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(25, 132);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 48);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(25, 186);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 48);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(25, 78);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(65, 48);
            btneliminar.TabIndex = 4;
            btneliminar.Text = "CE";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(96, 240);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 48);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(167, 240);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 48);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(96, 78);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(65, 48);
            btndivision.TabIndex = 9;
            btndivision.Text = "/";
            btndivision.UseVisualStyleBackColor = true;
            btndivision.Click += btndivision_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(96, 186);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 48);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(96, 132);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 48);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(167, 78);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(65, 48);
            btnmultiplicar.TabIndex = 12;
            btnmultiplicar.Text = "*";
            btnmultiplicar.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(167, 186);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 48);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(167, 132);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 48);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnresta
            // 
            btnresta.Location = new Point(238, 78);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(65, 48);
            btnresta.TabIndex = 13;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = true;
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(238, 132);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(65, 48);
            btnsuma.TabIndex = 14;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            btnraiz.Location = new Point(238, 186);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(65, 48);
            btnraiz.TabIndex = 15;
            btnraiz.Text = "√";
            btnraiz.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            btnigual.Location = new Point(238, 240);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(65, 102);
            btnigual.TabIndex = 16;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(25, 294);
            btn0.Name = "btn0";
            btn0.Size = new Size(136, 48);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnpunto
            // 
            btnpunto.Location = new Point(167, 294);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(65, 48);
            btnpunto.TabIndex = 18;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = true;
            btnpunto.Click += btnpunto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 364);
            Controls.Add(btnpunto);
            Controls.Add(btn0);
            Controls.Add(btnigual);
            Controls.Add(btnraiz);
            Controls.Add(btnsuma);
            Controls.Add(btnresta);
            Controls.Add(btnmultiplicar);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btndivision);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btneliminar);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn1);
            Controls.Add(Pantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Pantalla;
        private Button btn1;
        private Button btn7;
        private Button btn4;
        private Button btneliminar;
        private Button btn2;
        private Button btn3;
        private Button btndivision;
        private Button btn5;
        private Button btn8;
        private Button btnmultiplicar;
        private Button btn6;
        private Button btn9;
        private Button btnresta;
        private Button btnsuma;
        private Button btnraiz;
        private Button btnigual;
        private Button btn0;
        private Button btnpunto;
    }
}
