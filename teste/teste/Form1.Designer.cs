namespace teste
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
            textBoxRazaoSocial = new TextBox();
            textBoxNomeFantasia = new TextBox();
            comboBoxSituacaoCadastral = new ComboBox();
            SimplesNacional = new RadioButton();
            LucroPresumido = new RadioButton();
            LucroReal = new RadioButton();
            dateTimePickerDataInicioAtividade = new DateTimePicker();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxCapitalSocial = new TextBox();
            textBoxEndereco = new TextBox();
            comboBoxEstado = new ComboBox();
            radioButtonMatriz = new RadioButton();
            radioButton5 = new RadioButton();
            Pequeno = new RadioButton();
            Medio = new RadioButton();
            Grande = new RadioButton();
            comboBoxNaturezaJuridica = new ComboBox();
            textBoxNomeProprietario = new TextBox();
            maskedTextBoxCPFProprietario = new MaskedTextBox();
            buttonCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            maskedTextBoxCNPJ = new MaskedTextBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxRazaoSocial
            // 
            textBoxRazaoSocial.Location = new Point(101, 111);
            textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            textBoxRazaoSocial.Size = new Size(197, 23);
            textBoxRazaoSocial.TabIndex = 1;
            // 
            // textBoxNomeFantasia
            // 
            textBoxNomeFantasia.Location = new Point(100, 173);
            textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            textBoxNomeFantasia.Size = new Size(198, 23);
            textBoxNomeFantasia.TabIndex = 2;
            // 
            // comboBoxSituacaoCadastral
            // 
            comboBoxSituacaoCadastral.FormattingEnabled = true;
            comboBoxSituacaoCadastral.Items.AddRange(new object[] { "Ativo", "Nulo", "Suspensa", "Inapta", "Baixada" });
            comboBoxSituacaoCadastral.Location = new Point(100, 236);
            comboBoxSituacaoCadastral.Name = "comboBoxSituacaoCadastral";
            comboBoxSituacaoCadastral.Size = new Size(198, 23);
            comboBoxSituacaoCadastral.TabIndex = 3;
            // 
            // SimplesNacional
            // 
            SimplesNacional.AutoSize = true;
            SimplesNacional.Location = new Point(6, 9);
            SimplesNacional.Name = "SimplesNacional";
            SimplesNacional.Size = new Size(116, 19);
            SimplesNacional.TabIndex = 4;
            SimplesNacional.TabStop = true;
            SimplesNacional.Text = "Simples Nacional";
            SimplesNacional.UseVisualStyleBackColor = true;
            SimplesNacional.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // LucroPresumido
            // 
            LucroPresumido.AutoSize = true;
            LucroPresumido.Location = new Point(6, 34);
            LucroPresumido.Name = "LucroPresumido";
            LucroPresumido.Size = new Size(115, 19);
            LucroPresumido.TabIndex = 5;
            LucroPresumido.TabStop = true;
            LucroPresumido.Text = "Lucro Presumido";
            LucroPresumido.UseVisualStyleBackColor = true;
            // 
            // LucroReal
            // 
            LucroReal.AutoSize = true;
            LucroReal.Location = new Point(6, 59);
            LucroReal.Name = "LucroReal";
            LucroReal.Size = new Size(80, 19);
            LucroReal.TabIndex = 6;
            LucroReal.TabStop = true;
            LucroReal.Text = "Lucro Real";
            LucroReal.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataInicioAtividade
            // 
            dateTimePickerDataInicioAtividade.Location = new Point(98, 409);
            dateTimePickerDataInicioAtividade.Name = "dateTimePickerDataInicioAtividade";
            dateTimePickerDataInicioAtividade.Size = new Size(200, 23);
            dateTimePickerDataInicioAtividade.TabIndex = 7;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(98, 471);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(200, 23);
            maskedTextBoxTelefone.TabIndex = 8;
            // 
            // textBoxCapitalSocial
            // 
            textBoxCapitalSocial.Location = new Point(420, 56);
            textBoxCapitalSocial.Name = "textBoxCapitalSocial";
            textBoxCapitalSocial.Size = new Size(186, 23);
            textBoxCapitalSocial.TabIndex = 9;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(425, 111);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(181, 23);
            textBoxEndereco.TabIndex = 10;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(425, 173);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(181, 23);
            comboBoxEstado.TabIndex = 11;
            // 
            // radioButtonMatriz
            // 
            radioButtonMatriz.AutoSize = true;
            radioButtonMatriz.Location = new Point(59, 9);
            radioButtonMatriz.Name = "radioButtonMatriz";
            radioButtonMatriz.Size = new Size(58, 19);
            radioButtonMatriz.TabIndex = 12;
            radioButtonMatriz.TabStop = true;
            radioButtonMatriz.Text = "Matriz";
            radioButtonMatriz.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(4, 9);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(49, 19);
            radioButton5.TabIndex = 13;
            radioButton5.TabStop = true;
            radioButton5.Text = "Filial";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Pequeno
            // 
            Pequeno.AutoSize = true;
            Pequeno.Location = new Point(2, 9);
            Pequeno.Name = "Pequeno";
            Pequeno.Size = new Size(72, 19);
            Pequeno.TabIndex = 14;
            Pequeno.TabStop = true;
            Pequeno.Text = "Pequeno";
            Pequeno.UseVisualStyleBackColor = true;
            // 
            // Medio
            // 
            Medio.AutoSize = true;
            Medio.Location = new Point(80, 9);
            Medio.Name = "Medio";
            Medio.Size = new Size(59, 19);
            Medio.TabIndex = 15;
            Medio.TabStop = true;
            Medio.Text = "Médio";
            Medio.UseVisualStyleBackColor = true;
            // 
            // Grande
            // 
            Grande.AutoSize = true;
            Grande.Location = new Point(145, 9);
            Grande.Name = "Grande";
            Grande.Size = new Size(63, 19);
            Grande.TabIndex = 16;
            Grande.TabStop = true;
            Grande.Text = "Grande";
            Grande.UseVisualStyleBackColor = true;
            // 
            // comboBoxNaturezaJuridica
            // 
            comboBoxNaturezaJuridica.FormattingEnabled = true;
            comboBoxNaturezaJuridica.Items.AddRange(new object[] { "EI - Empresário Individual", "MEI - Microempreendedor Individual", "Sociedade Anônima" });
            comboBoxNaturezaJuridica.Location = new Point(420, 363);
            comboBoxNaturezaJuridica.Name = "comboBoxNaturezaJuridica";
            comboBoxNaturezaJuridica.Size = new Size(186, 23);
            comboBoxNaturezaJuridica.TabIndex = 17;
            // 
            // textBoxNomeProprietario
            // 
            textBoxNomeProprietario.Location = new Point(420, 421);
            textBoxNomeProprietario.Name = "textBoxNomeProprietario";
            textBoxNomeProprietario.Size = new Size(186, 23);
            textBoxNomeProprietario.TabIndex = 18;
            // 
            // maskedTextBoxCPFProprietario
            // 
            maskedTextBoxCPFProprietario.Location = new Point(418, 471);
            maskedTextBoxCPFProprietario.Mask = "000.000.000-00";
            maskedTextBoxCPFProprietario.Name = "maskedTextBoxCPFProprietario";
            maskedTextBoxCPFProprietario.Size = new Size(184, 23);
            maskedTextBoxCPFProprietario.TabIndex = 19;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(289, 517);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(131, 37);
            buttonCadastrar.TabIndex = 20;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 21;
            label1.Text = "CNPJ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 93);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 22;
            label2.Text = "Razão social:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 155);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 23;
            label3.Text = "Nome fantasia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 218);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 24;
            label4.Text = "Situação cadastral:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 280);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 25;
            label5.Text = "Regime tributário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 391);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 26;
            label6.Text = "Data de ínicio de Atividade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 453);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 27;
            label7.Text = "Telefone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 92);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 28;
            label8.Text = "Endereço:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 155);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 29;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 218);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 30;
            label10.Text = "Tipo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(418, 277);
            label11.Name = "label11";
            label11.Size = new Size(102, 15);
            label11.TabIndex = 31;
            label11.Text = "Porte da empresa:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(422, 36);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 32;
            label12.Text = "Capital social:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(418, 345);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 33;
            label13.Text = "Natureza jurídica:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(416, 403);
            label14.Name = "label14";
            label14.Size = new Size(125, 15);
            label14.TabIndex = 34;
            label14.Text = "Nome do proprietário:";
            // 
            // maskedTextBoxCNPJ
            // 
            maskedTextBoxCNPJ.Location = new Point(100, 54);
            maskedTextBoxCNPJ.Mask = "00.000.000/0000-00";
            maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            maskedTextBoxCNPJ.Size = new Size(198, 23);
            maskedTextBoxCNPJ.TabIndex = 35;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(420, 453);
            label15.Name = "label15";
            label15.Size = new Size(113, 15);
            label15.TabIndex = 36;
            label15.Text = "CPF do proprietário:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LucroReal);
            groupBox1.Controls.Add(LucroPresumido);
            groupBox1.Controls.Add(SimplesNacional);
            groupBox1.Location = new Point(101, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 90);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButtonMatriz);
            groupBox2.Location = new Point(427, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 34);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Pequeno);
            groupBox3.Controls.Add(Medio);
            groupBox3.Controls.Add(Grande);
            groupBox3.Location = new Point(420, 298);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(216, 44);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 576);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label15);
            Controls.Add(maskedTextBoxCNPJ);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxCPFProprietario);
            Controls.Add(textBoxNomeProprietario);
            Controls.Add(comboBoxNaturezaJuridica);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxEndereco);
            Controls.Add(textBoxCapitalSocial);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(dateTimePickerDataInicioAtividade);
            Controls.Add(comboBoxSituacaoCadastral);
            Controls.Add(textBoxNomeFantasia);
            Controls.Add(textBoxRazaoSocial);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxRazaoSocial;
        private TextBox textBoxNomeFantasia;
        private ComboBox comboBoxSituacaoCadastral;
        private RadioButton SimplesNacional;
        private RadioButton LucroPresumido;
        private RadioButton LucroReal;
        private DateTimePicker dateTimePickerDataInicioAtividade;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBoxCapitalSocial;
        private TextBox textBoxEndereco;
        private ComboBox comboBoxEstado;
        private RadioButton radioButtonMatriz;
        private RadioButton radioButton5;
        private RadioButton Pequeno;
        private RadioButton Medio;
        private RadioButton Grande;
        private ComboBox comboBoxNaturezaJuridica;
        private TextBox textBoxNomeProprietario;
        private MaskedTextBox maskedTextBoxCPFProprietario;
        private Button buttonCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private MaskedTextBox maskedTextBoxCNPJ;
        private Label label15;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}