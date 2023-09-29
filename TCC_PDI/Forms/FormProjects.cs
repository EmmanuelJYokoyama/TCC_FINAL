using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TCC_PDI.Forms
{
    public partial class FormProjects : Form
    {
        public FormProjects()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormatarGrid()
        {
            grid_projetos.Columns[0].HeaderText = "ID";
            grid_projetos.Columns[1].HeaderText = "Nome Projeto";
            grid_projetos.Columns[2].HeaderText = "Imagem";
            grid_projetos.Columns[3].HeaderText = "Largura";
            grid_projetos.Columns[4].HeaderText = "Altura";
            grid_projetos.Columns[5].HeaderText = "Status";
            grid_projetos.Columns[6].HeaderText = "Data";
            grid_projetos.Columns[7].HeaderText = "Comentario";

        }

        private void ListaDados()
        {
            string database = "SERVER=localhost;DATABASE=pdi;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(database);
            con.Open();
            string sql = "SELECT * FROM dados_projeto ORDER BY idProjeto ASC";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_projetos.DataSource = dt;

            con.Close();
            cmd.Connection.Close();
            FormatarGrid();
        }

        private void FormProjects_Load(object sender, EventArgs e)
        {
            grid_projetos.AllowUserToDeleteRows = false;
            grid_projetos.AllowUserToAddRows = false;
            grid_projetos.AllowUserToResizeRows = false;
            grid_projetos.AllowUserToResizeColumns = false;

            ListaDados();
        }
    }
}
