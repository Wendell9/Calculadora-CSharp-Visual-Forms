﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 14;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "÷";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "X";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int posicao, posicao1, posicao2;
            double resultado = 0;
            double[] a = new double[2];
            double[] b = new double[2];
            string operacao = this.Controls["textBox1"].Text;
        Inicio:
            if (operacao.IndexOf('X') < operacao.IndexOf('÷'))
            {
                if (operacao.Contains('X'))
                {
                    posicao = operacao.IndexOf("X");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'X');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.multiplicacao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('÷'))
                {
                    posicao = operacao.IndexOf("÷");
                    a = Operacoes.coletanumerosantes(operacao, posicao, '÷');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao); ;
                    posicao2 = (int)b[1];
                    resultado = Operacoes.divisao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'+');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.soma(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao[0] != '-' && operacao.Contains('-'))
                {
                    posicao = operacao.IndexOf("-");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'-');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.subtracao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
            }
            else
            {
                if (operacao.Contains('÷'))
                {
                    posicao = operacao.IndexOf("÷");
                    a = Operacoes.coletanumerosantes(operacao, posicao, '÷');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao); 
                    posicao2 = (int)b[1];
                    resultado = Operacoes.divisao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('X'))
                {
                    posicao = operacao.IndexOf("X");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'X');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.multiplicacao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString(CultureInfo.InvariantCulture));
                    goto Inicio;
                }
                else if (operacao.Substring(1).Contains('+'))
                {
                    posicao = operacao.IndexOf("+");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'+');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.soma(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
                else if (operacao.Contains('-'))
                {
                    if (operacao.IndexOf("-", 1) == -1)
                    {
                        goto Fim;
                    }
                    posicao = operacao.IndexOf("-");
                    a = Operacoes.coletanumerosantes(operacao, posicao,'-');
                    posicao1 = (int)a[1];
                    b = Operacoes.coletanumerodepois(operacao, posicao);
                    posicao2 = (int)b[1];
                    resultado = Operacoes.subtracao(a[0], b[0]);
                    operacao = operacao.Replace(operacao.Substring(posicao1, posicao2 - posicao1), resultado.ToString());
                    goto Inicio;
                }
            }
        Fim:
            this.Controls["textBox1"].Text = resultado.ToString("0.################", CultureInfo.InvariantCulture);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Controls["textBox1"].Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 outroform = new Form1();
            outroform.Visible = true;
            this.Visible = false;
        }
    }
}
