using System.Reflection.Emit;

namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pantalla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonProd = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.pantallaOp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pantalla.Location = new System.Drawing.Point(13, 58);
            this.pantalla.MaxLength = 30;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(319, 20);
            this.pantalla.TabIndex = 1;
            this.pantalla.TabStop = false;
            this.pantalla.Text = "0";
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(94, 171);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(176, 171);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(94, 200);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(13, 200);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonInvert.TabIndex = 12;
            this.buttonInvert.Text = "+/-";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(176, 200);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 23);
            this.buttonDot.TabIndex = 13;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(257, 113);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(257, 142);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonProd
            // 
            this.buttonProd.Location = new System.Drawing.Point(257, 171);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(75, 23);
            this.buttonProd.TabIndex = 16;
            this.buttonProd.Text = "*";
            this.buttonProd.UseVisualStyleBackColor = true;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(257, 200);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 17;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonResult.Location = new System.Drawing.Point(257, 229);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 18;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCE.Location = new System.Drawing.Point(176, 84);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(75, 23);
            this.buttonCE.TabIndex = 19;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(13, 238);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 20;
            this.versionLabel.Text = "Versión ";
            // 
            // buttonExp
            // 
            this.buttonExp.Location = new System.Drawing.Point(94, 84);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(75, 23);
            this.buttonExp.TabIndex = 21;
            this.buttonExp.Text = "x²";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonC.Location = new System.Drawing.Point(257, 84);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 22;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // pantallaOp
            // 
            this.pantallaOp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pantallaOp.Location = new System.Drawing.Point(12, 32);
            this.pantallaOp.MaxLength = 30;
            this.pantallaOp.Name = "pantallaOp";
            this.pantallaOp.ReadOnly = true;
            this.pantallaOp.Size = new System.Drawing.Size(320, 20);
            this.pantallaOp.TabIndex = 23;
            this.pantallaOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.pantallaOp);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonProd);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pantalla);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.TextBox pantallaOp;
    }
}

