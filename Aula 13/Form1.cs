using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente cc = new ContaCorrente();

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = cc.Saldo.ToString();
            txtValor.Text = null;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            cc.Agencia =txtAgencia.Text;
            cc.Numero = txtConta.Text;
            cc.Titular = txtTitular.Text;
            cc.Saldo = Convert.ToDouble(txtSaldo.Text);
            cc.Limite = 500;
            MessageBox.Show("Conta criadacom sucesso!!");
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titular:" + cc.Titular + "\nAgência:" +
                cc.Agencia + "\nNúmero da Conta: " + cc.Numero + "\nSaldo: " +
                cc.Saldo.ToString("C")+"\nValor de juros:" + 
                cc.Calcular().ToString("C"));
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            cc.Sacar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = cc.Saldo.ToString();
            txtValor.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
