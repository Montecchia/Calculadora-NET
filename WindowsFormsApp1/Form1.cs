using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string version = "0.1";
       
        private string operacionActual = "";

        public bool resultadoActivo = true;

        private void PresionarTecla(char tecla)
        {

            if (pantalla.Text == "Syntax error" || pantalla.Text == "Overflow")
            {
                clrall();
            }

            if (resultadoActivo)
            {
                if (tecla >= '0' && tecla <= '9')
                {
                    clrop();
                    clrscr();
                }
                resultadoActivo = false;
            }

            if (tecla >= '0' && tecla <= '9')
            { 
                pantalla.Text += tecla;
            }
            else if (tecla == '=')
            {
                operacionActual += pantalla.Text;
                //Console.WriteLine(operacionActual);
                Operaciones operacion = new Operaciones();
                pantalla.Text = operacion.obtenerResultado(operacionActual);
                clrop();
                //operacionActual = pantalla.Text;
                resultadoActivo = true;
            }
            else if (tecla == 'I')
            {
                if (pantalla.Text.First().Equals('-'))
                {
                    pantalla.Text = pantalla.Text.Substring(1);
                }
                else if (!pantalla.Text.Equals(""))
                {
                    pantalla.Text = pantalla.Text.Insert(0, "-");
                }
            }
            else if (tecla == '.')
            {
                if (!pantalla.Text.Contains('.'))
                {
                    pantalla.Text += '.';
                }
            }
            else if (tecla == '^')
            {
                operacionActual += pantalla.Text + "*" + pantalla.Text;
                Console.WriteLine("Operacion Actual: " + operacionActual + "\nPantalla: " + pantalla.Text);
                clrscr();
                PresionarTecla('=');
            }
            else
            {
                Console.WriteLine(pantalla.Text);
                operacionActual += pantalla.Text + tecla;
                clrscr();
            }
        }

        private void clrscr() => pantalla.Text = "";

        private void clrop() => operacionActual = "";

        private void clrall()
        {
            clrscr();
            clrop();
            resultadoActivo = false;
        }

        public Form1()
        {
            InitializeComponent();
            versionLabel.Text += version;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PresionarTecla('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PresionarTecla('2');
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PresionarTecla('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PresionarTecla('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PresionarTecla('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PresionarTecla('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PresionarTecla('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PresionarTecla('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PresionarTecla('9');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            PresionarTecla('0');
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            PresionarTecla('I');
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            PresionarTecla('.');
        }
            

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            PresionarTecla('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            PresionarTecla('-');
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            PresionarTecla('*');
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            PresionarTecla('/');
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            PresionarTecla('=');
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {
            pantallaOp.Text = operacionActual;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            clrop();
            resultadoActivo = true;
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            PresionarTecla('^');
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            clrscr();
        }
    }
}
