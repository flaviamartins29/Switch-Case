using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                /*O conteudo da combox (cboSemana) será analisado e de acordo com a opção escolhida
                 aparecerá uma determinada mensagem, caso o usuario escolha Domingo, será msg, 
                caso seja segunda será outra msg e assim por diante
                o BREAK serva para para sair de determado comando, neste exemplo o case em exeção*/
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo, que é o primeiro dia ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Segunda":
                    MessageBox.Show("Você escolheu Sengunda, que é o segundo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça que é o terceiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta que é o quarto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta que é o quinto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta que é o sexto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sabado":
                    MessageBox.Show("Você escolheu Sabado que é o sétimo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;




            }
        }
    }
}
