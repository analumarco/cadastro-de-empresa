using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System;

namespace teste
{
    public partial class Form1 : Form
    {
        private List<Empresa> empresas = new List<Empresa>();
        public Form1()
        {
            InitializeComponent();
            comboBoxEstado.Items.AddRange(new string[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBoxSituacaoCadastral.SelectedIndex = 0;
            comboBoxNaturezaJuridica.SelectedIndex = 0;

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string CNPJ = maskedTextBoxCNPJ.Text;
                string Razaosocial = textBoxRazaoSocial.Text;
                string Nomefantasia = textBoxNomeFantasia.Text;
                string Situacaocadastral = comboBoxSituacaoCadastral.Text;
                string Regimetributario;
                string Datainicio = dateTimePickerDataInicioAtividade.Text;
                string Telefone = maskedTextBoxTelefone.Text;
                string Capitalsocial = textBoxCapitalSocial.Text;
                string Rua = textBoxEndereco.Text;
                string Estado = comboBoxEstado.Text;
                string Tipo;
                string PorteEmpresa;
                string Naturezapolitica = comboBoxNaturezaJuridica.Text;
                string Nomeproprietario = textBoxNomeProprietario.Text;
                string Cpfproprietario = maskedTextBoxCPFProprietario.Text;

                if (SimplesNacional.Checked == true)
                {
                    Regimetributario = SimplesNacional.Text;
                }
                else if (LucroPresumido.Checked == true)
                {
                    Regimetributario = LucroPresumido.Text;
                }
                else if (LucroReal.Checked == true)
                {
                    Regimetributario = LucroReal.Text;
                }

                if (Pequeno.Checked == true)
                {
                    PorteEmpresa = Pequeno.Text;
                }
                else if (Medio.Checked == true)
                {
                    PorteEmpresa = Medio.Text;
                }
                else if (Grande.Checked == true)
                {
                    PorteEmpresa = Grande.Text;
                }


                MessageBox.Show($"{CNPJ} {Razaosocial} {Nomefantasia} {Situacaocadastral}  {Datainicio} {Telefone}{Capitalsocial}{Rua} {Bairro} {Cidade} {Numero} {Cep}{Estado}  {Naturezapolitica} {Nomeproprietario} {Cpfproprietario}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetRegimeTributarioSelecionado()
        {
            if (SimplesNacional.Checked)
                return "Simples Nacional";
            else if (LucroPresumido.Checked)
                return "Lucro Presumido";
            else if (LucroReal.Checked)
                return "Real";
            else
                return string.Empty;
        }

        private string GetPorteEmpresaSelecionado()
        {
            if (Pequeno.Checked)
                return "Pequeno";
            else if (Medio.Checked)
                return "Médio";
            else if (Grande.Checked)
                return "Grande";
            else
                return string.Empty;
        }

        private void LimparCampos()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        public class Empresa
        {
            public string CNPJ { get; set; }
            public string RazaoSocial { get; set; }
            public string NomeFantasia { get; set; }
            public string SituacaoCadastral { get; set; }
            public string RegimeTributario { get; set; }
            public DateTime DataInicioAtividade { get; set; }
            public string Telefone { get; set; }
            public decimal CapitalSocial { get; set; }
            public string Endereco { get; set; }
            public string Estado { get; set; }
            public string Tipo { get; set; }
            public string PorteEmpresa { get; set; }
            public string NaturezaJuridica { get; set; }
            public string NomeProprietario { get; set; }
            public string CPFProprietario { get; set; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

