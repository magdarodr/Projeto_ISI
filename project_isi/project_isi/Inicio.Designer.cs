namespace Project_ISI
{
    partial class inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalcC = new System.Windows.Forms.Button();
            this.comboBoxAtividade = new System.Windows.Forms.ComboBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxAlturaC = new System.Windows.Forms.TextBox();
            this.radioButtonFC = new System.Windows.Forms.RadioButton();
            this.radioButtonMC = new System.Windows.Forms.RadioButton();
            this.textBoxIdadeC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonCalcC);
            this.tabPage2.Controls.Add(this.comboBoxAtividade);
            this.tabPage2.Controls.Add(this.textBoxPeso);
            this.tabPage2.Controls.Add(this.textBoxAlturaC);
            this.tabPage2.Controls.Add(this.radioButtonFC);
            this.tabPage2.Controls.Add(this.radioButtonMC);
            this.tabPage2.Controls.Add(this.textBoxIdadeC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculadora de Calorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 104);
            this.label6.TabIndex = 12;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // buttonCalcC
            // 
            this.buttonCalcC.Location = new System.Drawing.Point(19, 295);
            this.buttonCalcC.Name = "buttonCalcC";
            this.buttonCalcC.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcC.TabIndex = 11;
            this.buttonCalcC.Text = "Calcular";
            this.buttonCalcC.UseVisualStyleBackColor = true;
            this.buttonCalcC.Click += new System.EventHandler(this.buttonCalcC_Click);
            // 
            // comboBoxAtividade
            // 
            this.comboBoxAtividade.FormattingEnabled = true;
            this.comboBoxAtividade.Items.AddRange(new object[] {
            "TMB",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxAtividade.Location = new System.Drawing.Point(98, 219);
            this.comboBoxAtividade.Name = "comboBoxAtividade";
            this.comboBoxAtividade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAtividade.TabIndex = 10;
            this.comboBoxAtividade.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtividade_SelectedIndexChanged);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(98, 171);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(121, 20);
            this.textBoxPeso.TabIndex = 9;
            this.textBoxPeso.TextChanged += new System.EventHandler(this.textBoxPeso_TextChanged);
            // 
            // textBoxAlturaC
            // 
            this.textBoxAlturaC.Location = new System.Drawing.Point(98, 127);
            this.textBoxAlturaC.Name = "textBoxAlturaC";
            this.textBoxAlturaC.Size = new System.Drawing.Size(121, 20);
            this.textBoxAlturaC.TabIndex = 8;
            this.textBoxAlturaC.TextChanged += new System.EventHandler(this.textBoxAlturaC_TextChanged);
            // 
            // radioButtonFC
            // 
            this.radioButtonFC.AutoSize = true;
            this.radioButtonFC.Location = new System.Drawing.Point(177, 79);
            this.radioButtonFC.Name = "radioButtonFC";
            this.radioButtonFC.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFC.TabIndex = 7;
            this.radioButtonFC.TabStop = true;
            this.radioButtonFC.Text = "Feminino";
            this.radioButtonFC.UseVisualStyleBackColor = true;
            this.radioButtonFC.CheckedChanged += new System.EventHandler(this.radioButtonFC_CheckedChanged);
            // 
            // radioButtonMC
            // 
            this.radioButtonMC.AutoSize = true;
            this.radioButtonMC.Location = new System.Drawing.Point(87, 79);
            this.radioButtonMC.Name = "radioButtonMC";
            this.radioButtonMC.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMC.TabIndex = 6;
            this.radioButtonMC.TabStop = true;
            this.radioButtonMC.Text = "Masculino";
            this.radioButtonMC.UseVisualStyleBackColor = true;
            this.radioButtonMC.CheckedChanged += new System.EventHandler(this.radioButtonMC_CheckedChanged);
            // 
            // textBoxIdadeC
            // 
            this.textBoxIdadeC.Location = new System.Drawing.Point(98, 21);
            this.textBoxIdadeC.Name = "textBoxIdadeC";
            this.textBoxIdadeC.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdadeC.TabIndex = 5;
            this.textBoxIdadeC.TextChanged += new System.EventHandler(this.textBoxIdadeC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atividade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura \r\n(em cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCalc);
            this.tabPage1.Controls.Add(this.radioButtonF);
            this.tabPage1.Controls.Add(this.radioButtonM);
            this.tabPage1.Controls.Add(this.textBoxAltura);
            this.tabPage1.Controls.Add(this.textBoxIdade);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 350);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Calculadora Peso Ideal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(39, 266);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 7;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(229, 102);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonF.TabIndex = 6;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Feminino";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(98, 102);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(73, 17);
            this.radioButtonM.TabIndex = 5;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculino";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(98, 170);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(110, 20);
            this.textBoxAltura.TabIndex = 4;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBoxAltura_TextChanged);
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(98, 31);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(110, 20);
            this.textBoxIdade.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Altura\r\n(em cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Género";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Idade";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(820, 350);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Gestor Refeições";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lista de Informação de Calorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InfoCalc_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "inicio";
            this.Text = "Início";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxAlturaC;
        private System.Windows.Forms.RadioButton radioButtonFC;
        private System.Windows.Forms.RadioButton radioButtonMC;
        private System.Windows.Forms.TextBox textBoxIdadeC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCalcC;
        private System.Windows.Forms.ComboBox comboBoxAtividade;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button button1;
    }
}

