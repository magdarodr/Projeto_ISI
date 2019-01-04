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
    public partial class inicio : Form
    {
        private double BMR;

        public inicio()
        {
            InitializeComponent();

            //buttonCalc.Enable = false;
        }

        // Calculadora de Calorias

        private void buttonCalcC_Click(object sender, EventArgs e)
        {
            double altura, idade, peso, caloria;
            string atividade;

            if (textBoxIdadeC.Text == "")
            {
                MessageBox.Show("Introduza a idade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxIdadeC.Focus();
            }
            else
            {
                if (textBoxAlturaC.Text == "")
                {
                    MessageBox.Show("Introduza a altura", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAlturaC.Focus();
                }
                else
                {
                    if (textBoxPeso.Text == "")
                    {
                        MessageBox.Show("Introduza o peso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxPeso.Focus();
                    }
                    else
                    {
                        //Métodos que convertem em double, o valor inserido nas textBox
                        idade = Convert.ToDouble(textBoxIdadeC.Text);
                        altura = Convert.ToDouble(textBoxAlturaC.Text);
                        peso = Convert.ToDouble(textBoxPeso.Text);

                        //Método para extrair o valor selecionado na comboBox
                        atividade = comboBoxAtividade.SelectedItem.ToString();

                        switch (atividade)
                        {
                            case "Atividades":
                                MessageBox.Show("Selecione a atividade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case "TMB":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = (655.1 + (9.5 * peso) + (1.8 * altura) - (4.7 * idade));
                                    MessageBox.Show("A sua Taxa de Metabolismo Basal é de " + BMR.ToString());
                                }
                                else
                                {
                                    BMR = (66.5 + (13.8 * peso) + (5 * altura) - (6.8 * idade));
                                    MessageBox.Show("A sua Taxa de Metabolismo Basal é de " + BMR.ToString());
                                }
                                break;
                            case "1":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
                                    caloria = (BMR * 0.0012);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                else
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
                                    caloria = (BMR * 0.0012);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                break;
                            case "2":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
                                    caloria = (BMR * 1.375);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                else
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
                                    caloria = (BMR * 1.375);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                break;
                            case "3":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
                                    caloria = (BMR * 1.55);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                else
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
                                    caloria = (BMR * 1.55);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter o seu peso.");
                                }
                                break;
                            case "4":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
                                    caloria = (BMR * 1.725);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter seu peso.");
                                }
                                else
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
                                    caloria = (BMR * 1.725);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter seu peso.");
                                }
                                break;
                            case "5":
                                if (radioButtonFC.Checked)
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) - 161);
                                    caloria = (BMR * 1.9);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter seu peso.");
                                }
                                else
                                {
                                    BMR = ((10 * peso) + (6.25 * altura) - (5 * idade) + 5);
                                    caloria = (BMR * 1.9);
                                    MessageBox.Show("Você precisa de " + caloria.ToString() + " calorias/dia para manter seu peso.");
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void textBoxIdadeC_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlturaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Peso Ideal

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxAltura.Text, out double altura);
            //if (altura == null) return;

            double peso_ideal = 0;
            double inAMais = 0;
            double aux = 0;
            double fiveft = 152.4;

            // aux é a diferença de centimetros entre a altura inserida
            // e os 5ft da formula que traduzido em centimetros dá
            // 152.4 centimetros
            aux = altura - fiveft;

            //inAMais vai calcular os inches a mais alem dos 5ft
            //apresentados na formula. Aux vai ser dividido por 2.54
            // pois 2.54cm é o valor de 1in
            inAMais = aux / 2.54;


            //m = ft/(3.2808);


            if (radioButtonM.Checked)
            {
                //Male: 56.2 kg + 1.41 kg per inch over 5 feet
                //Masculino
                peso_ideal = 56.2 + (1.41 * inAMais);


            }
            else
            {
                //Female:	53.1 kg + 1.36 kg per inch over 5 feet
                //Feminino
                peso_ideal = 53.1 + (1.36 * inAMais);
            }

            StringBuilder str = new StringBuilder("Peso Ideal: " + peso_ideal.ToString("0.00") + " kg");
            MessageBox.Show(str.ToString());
        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {
            buttonCalc.Enabled = textBoxAltura.Text != "" ? true : false;
        }

        // Gestor de Informação Calorica

        private void InfoCalc_Click(object sender, EventArgs e)
        {
            gestorInfoCal GestorInfoCal = new gestorInfoCal();
            GestorInfoCal.ShowDialog();
        }
    }
}

