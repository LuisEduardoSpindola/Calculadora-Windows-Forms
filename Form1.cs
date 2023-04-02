using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto02
{
    public partial class Form1 : Form
    {

        decimal primeiroValor;
        decimal segundoValor;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void resultLabel_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void um_Click(object sender, EventArgs e)
        {
            
            resultLabel.Text += "1";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "3";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "6";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "7";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "8";
        }

        private void nove_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "0";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            resultLabel.Text += ".";
        }

        private void somar_Click(object sender, EventArgs e)
        { 
            primeiroValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);
            resultLabel.Text = "";
            operacao = "Somar";
            indicarOperacao.Text = "+";
        }



        

        private void subtrair_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);
            resultLabel.Text = "";
            operacao = "Subtrair";
            indicarOperacao.Text = "-";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);
            resultLabel.Text = "";
            operacao = "Multiplicar";
            indicarOperacao.Text = "Multiplicar";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);
            resultLabel.Text = "";
            operacao = "Dividir";
            indicarOperacao.Text = "Dividir";
        }

        private void porcento_Click(object sender, EventArgs e)
        {
            primeiroValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);
            operacao = "Porcentagem";
            indicarOperacao.Text = "Porcentagem";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            indicarOperacao.Text = "";
        }

        //------------------------

        private void igual_Click(object sender, EventArgs e)
        {
            segundoValor = decimal.Parse(resultLabel.Text, CultureInfo.InvariantCulture);


            if (operacao == "Somar")
            {
                resultLabel.Text = Convert.ToString(primeiroValor + segundoValor);
            }

            if (operacao == "Subtrair")
            {
                resultLabel.Text = Convert.ToString(primeiroValor - segundoValor);
            }

            if (operacao == "Multiplicar")
            {
                resultLabel.Text = Convert.ToString(primeiroValor * segundoValor);
            }

            if (operacao == "Dividir") 
            {
                resultLabel.Text = Convert.ToString(primeiroValor / segundoValor);
            }

            if (operacao == "Porcentagem")
            {
                
                resultLabel.Text = Convert.ToString(primeiroValor / 100 + "%");
            }
        }

        private void indicadarOperacao_TextChanged(object sender, EventArgs e) { }

        private void sair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
