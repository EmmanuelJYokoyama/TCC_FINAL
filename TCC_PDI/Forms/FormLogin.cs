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
    public partial class FormLogin : Form
    {
        public static string cpf_cnpj;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
           
            if ((textCPF_CNPJ.Text != "") && (textSenha.Text != ""))
            {
                cpf_cnpj = textCPF_CNPJ.Text;
                string senha = textSenha.Text;
        
                if (verificarLogin(senha))
                {
                    FormImage destino = new FormImage();
                    this.Close();
                }
            }
        }
       

        bool verificarLogin(string senha)
        {
            string database = "SERVER=localhost;DATABASE=pdi;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(database);
            con.Open();

            MySqlCommand comandosql = con.CreateCommand();
            comandosql.CommandText = String.Format("select * from dados_empresa where cpf_cnpj = '{0}' and senha = MD5('{1}')", cpf_cnpj, senha);
            MySqlDataReader Query = comandosql.ExecuteReader();

            if (!Query.Read())
            {
                MessageBox.Show("Usuário inexistente");
                textCPF_CNPJ.Clear();
                textSenha.Clear();
                comandosql.Connection.Close();
                return false;
            }

            comandosql.Connection.Close();
            return true;
        }

        private void btnCadastroBack_Click(object sender, EventArgs e)
        {
            using (FormCadastro modal = new FormCadastro())
            {
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
