using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_PDI.Forms;

namespace TCC_PDI
{
    public partial class FormCadastro : Form
    {
 
        public static string cpf_cnpj;
        int[] multiplicadoresCPF_CNPJ;

        public FormCadastro()
        {
            FormLogin.ActiveForm.Visible = false;
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            inserirCmbBoxRamoAtividade();
            textCPF_CNPJ.TabIndex = 11;
            textCPF_CNPJ.Mask = "000,000,000-00";

            multiplicadoresCPF_CNPJ = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

        public void inserirCmbBoxRamoAtividade()
        {
            string database = "SERVER=localhost;DATABASE=pdi;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(database);
            MySqlCommand comandosql = con.CreateCommand();
            con.Open();

            comandosql.CommandText = String.Format("select ramo_atividade from dados_empresa");
            MySqlDataReader Query = comandosql.ExecuteReader();

            string ramoAtividade;

            while (Query.Read())
            {
                ramoAtividade = Query.GetString("ramo_atividade");
                cmbBoxRamoAtividade.Items.Add(ramoAtividade);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((textCPF_CNPJ.Text != "") && (textSenha.Text != "") && (textNomeEmpresa.Text != "") && (textSenha.Text != ""))
            {
                cpf_cnpj = textCPF_CNPJ.Text;
                string nomeEmpresa = textNomeEmpresa.Text;
                string ramoAtividade = cmbBoxRamoAtividade.Text;
                string senha = textSenha.Text;

                if (validarCPF_CNPJ())
                {
                    if(inserirDados(nomeEmpresa, ramoAtividade, senha))
                    {
                        FormImage destino = new FormImage();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("CPF/CNPJ inválido!");
                    textCPF_CNPJ.Clear();
                }
            }
        }

        bool inserirDados(string nomeEmpresa, string ramoAtividade, string senha)
        {
            string database = "SERVER=localhost;DATABASE=pdi;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(database);
            MySqlCommand comandosql = con.CreateCommand();
            con.Open();

            comandosql.CommandText = String.Format("select * from dados_empresa where cpf_cnpj = '{0}'", cpf_cnpj);
            MySqlDataReader Query = comandosql.ExecuteReader();


            if (!Query.Read())
            {
                con.Close();
                con.Open();
                comandosql.CommandText = String.Format(@"insert into dados_empresa values ('{0}', '{1}', '{2}', MD5('{3}'))", cpf_cnpj, nomeEmpresa, ramoAtividade, senha);
                comandosql.ExecuteNonQuery();
                comandosql.Connection.Close();
                MessageBox.Show("Inserido com sucesso!");
                return true;
            }
            else
            {
                MessageBox.Show("Esse CPF/CNPJ já está vinculado à uma conta!");
                return false;
            }

        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            using (FormLogin modal = new FormLogin())
            {
                FormCadastro.ActiveForm.Visible = false;
                modal.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textSenha.PasswordChar = default;
            else
                textSenha.PasswordChar = '*';
        }
        
        private bool validarCPF_CNPJ()
        {
            int soma = 0;
            int x = 1;
            for(int i = 0; i < cpf_cnpj.Length - 2; i++)
            {
                soma += int.Parse(cpf_cnpj.Substring(i, 1)) * multiplicadoresCPF_CNPJ[x++];
            }

            int resto = soma % 11;
            int DV1 = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            x = 0;
            for (int i = 0; i < cpf_cnpj.Length - 1; i++)
            {
                soma += int.Parse(cpf_cnpj.Substring(i, 1)) * multiplicadoresCPF_CNPJ[x++];
                
            }

            resto = soma % 11;
            int DV2 = resto < 2 ? 0 : 11 - resto;

            return int.Parse(cpf_cnpj[cpf_cnpj.Length - 2].ToString()) == DV1 && int.Parse(cpf_cnpj[cpf_cnpj.Length -1].ToString()) == DV2;

        }

        private void radiobtnCPF_CheckedChanged(object sender, EventArgs e)
        {
            textCPF_CNPJ.TabIndex = 11;
            textCPF_CNPJ.Mask = "000,000,000-00";
            label5.Text = "Nome do Usuario";
            
            multiplicadoresCPF_CNPJ = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

        private void radioBtnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            textCPF_CNPJ.TabIndex = 14;
            textCPF_CNPJ.Mask = "00,000,000/0000-00";
            label5.Text = "Nome da Empresa";

            multiplicadoresCPF_CNPJ = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

        private void textCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite seu CPF/CNPJ");
            }
        }
    }
}
