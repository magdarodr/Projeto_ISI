using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ISI
{
    public partial class gestorInfoCal : Form
    {
        public gestorInfoCal()
        {
            InitializeComponent();
        }

        private void abrirFicheiro_Click(object sender, EventArgs e)
        {
            //Abrir ficheiro na richTextBox
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

            }

            Console.WriteLine(result);

            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            /*
            #######################
            Converter JSON em XML
            #######################
            */

            // ir buscar o caminho do ficheiro;

            string caminho = @"C:\Users\joana\Desktop\ISI\ANEXOS";

            // carregar o conteúdo do ficheiro para uma string

            List<Refeicao> refeicoes = new List<Refeicao>();

            // parse da string



            // split pelo \n


            // em cada linha


            //split pelo \t


            // criar novo objecto do tipo refeicao


            // adicionar refeicao a uma lista de refeicoes


            // mostrar a lista de refeicoes numa textview

            /*
            textBoxRes.Text = "";
            foreach (Refeicao r in refeicoes)
            {
                textBoxRes.Text += r;
            }
            */
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var contaLinhas = richTextBox1.Lines.Count();
            label1.Text = contaLinhas.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
