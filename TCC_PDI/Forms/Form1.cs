using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCC_PDI
{
    public partial class Form1 : Form
    {
        private IconButton btnAtual;
        private Panel bordaBtn;
        private Form formAtivo;

        //Construtor
        public Form1()
        {
            using (FormLogin modal = new FormLogin())
            {
                modal.ShowDialog();
            }

            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            bordaBtn = new Panel();
            bordaBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(bordaBtn);
            //panelWindow = AbrirJanela();
        }

        //Métodos
        private void AtivarBtn(object  btn, Color cor)
        {    
            if(btn != null)
            {
                DesabilitarBtn();

                //Botão
                btnAtual = (IconButton)btn;
                btnAtual.BackColor = Color.FromArgb(37,36,81);
                btnAtual.ForeColor = cor;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = cor;
                btnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAtual.ImageAlign = ContentAlignment.MiddleRight;

                //Borda Esquerda de Botões
                bordaBtn.BackColor = cor;
                bordaBtn.Location = new Point(0, btnAtual.Location.Y);
                bordaBtn.Visible = true;
                bordaBtn.BringToFront();

            }
        }

        private void DesabilitarBtn()
        {
            if(btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(51, 51, 76);
                btnAtual.ForeColor = Color.Gainsboro;
                btnAtual.TextAlign = ContentAlignment.MiddleLeft;
                btnAtual.IconColor = Color.Gainsboro;
                btnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAtual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Resetar()
        {
            DesabilitarBtn();
            bordaBtn.Visible = false;
        }

        private void AbrirJanela(object btn, Form childForm)
        {
            if(formAtivo != null)
            {
                formAtivo.Close();
            }
            AtivarBtn(btn, Color.FromArgb(255, 145, 77));
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWindow.Controls.Add(childForm);
            this.panelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Botões

        private void btnUser_Click(object sender, EventArgs e)
        {
            AbrirJanela(sender, new Forms.FormUser());
            lblTitle.Text = "USUÁRIO";
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            AbrirJanela(sender, new Forms.FormImage());
            lblTitle.Text = "IMAGEM";
        }



        private void btnProject_Click(object sender, EventArgs e)
        {
            AbrirJanela(sender, new Forms.FormProjects());
            lblTitle.Text = "PROJETOS";
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Resetar();
        }

    }
}
