using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace TCC_PDI.Forms
{
    public partial class FormImage : Form
    {

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        
        bool foco;
        string cpf_cnpj;
        string nomeProjeto;
        int coluna;
        int linha;
        string status;
        string areaUtil;
        string comentario;
        string tempImgFonte;
        string tempImgProcessada;
        int pixelsBrancos;
        int pixelsPretos;

        Bitmap imgOriginal;
        Bitmap imgProcessada;
        

        public FormImage()
        {
            InitializeComponent();
            if (FormLogin.cpf_cnpj != null)
                this.cpf_cnpj = FormLogin.cpf_cnpj;
            else
                this.cpf_cnpj = FormCadastro.cpf_cnpj;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cmbCameras.Items.Add(filterInfo.Name);

            cmbCameras.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void FormImage_Load(object sender, EventArgs e)
        {
            
            nomeProjeto = Interaction.InputBox("Digite um nome para seu projeto: ", "", "", 400, 400);
            while (string.IsNullOrEmpty(nomeProjeto))
                nomeProjeto = Interaction.InputBox("Digite um nome para seu projeto: ", "", "", 400, 400);
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (foco)
            {
                picBoxCam.Image = (Bitmap)e.Frame.Clone();
                GC.Collect();
            }
        }

        Color definirCor(double r, double g, double b)
        {
            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        double Pixel_Centimetros(int pixels, char xy)
        {
            double centimetros;
            using (Graphics g = this.CreateGraphics())
            {
                if (xy.Equals('x'))
                    centimetros = pixels * 2.54 / g.DpiX;
                else
                    centimetros = pixels * 2.54 / g.DpiY;
            }
            return centimetros;
        }

        private void abrir_trocarCamera()
        {
            foco = true;
            carregar_img.Visible = false;
            tirarFoto.Visible = true;
            abrirCamera.Visible = false;

            videoCaptureDevice = new VideoCaptureDevice
            (filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void fecharCamera()
        {
            if (!(videoCaptureDevice == null))
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice = null;
                }
        }

        Bitmap ProcessarImg(int indiceLimiar)
        {
            coluna = linha = 0;
            coluna = imgOriginal.Width; // O número colunas
            linha = imgOriginal.Height; // O número de linhas

            Bitmap imgPretoBranco = new Bitmap(coluna, linha);

            //int[] histograma_GrayLevel = new int[256];
            pixelsBrancos = 0;
            pixelsPretos = 0;
            float areaOcupada = 0f;

            Color cor = new Color();

            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    double r = imgOriginal.GetPixel(i, j).R;
                    double g = imgOriginal.GetPixel(i, j).G;
                    double b = imgOriginal.GetPixel(i, j).B;

                    double K = r * 0.3 + g * 0.59 + b * 0.11;
                    //histograma_GrayLevel[(int)K] += 1;

                    if (K >= indiceLimiar)
                    {
                        K = 255;
                        pixelsBrancos++;
                    }
                    else
                    {
                        K = 0;
                        pixelsPretos++;
                    }

                    cor = definirCor(K, K, K);
                    imgPretoBranco.SetPixel(i, j, cor);

                }
            }

            areaOcupada = 100 * (pixelsBrancos / (float)(coluna * linha));

            label2.Text = areaOcupada.ToString("0.00") + "% da área total ocupada.";

            if (areaOcupada <= 33.3)
                label3.Text = "Ocupação ruim.";
            else if (areaOcupada <= 66.6)
                label3.Text = "Ocupação regular.";
            else
                label3.Text = "Boa ocupação.";

            status = label3.Text;
            areaUtil = label2.Text;
            comentario = txtBoxComentario.Text;

            /*File.WriteAllText(@"dados.xml", "<Registro>");
            for (int i = 0; i <= 255; i++)
            {
                File.AppendAllText(@"dados.xml", " < Dado>" + Environment.NewLine + "<Espectro>" + histograma_GrayLevel[i] + "</Espectro>" + Environment.NewLine + "</Dado>");
            }
            File.AppendAllText(@"dados.xml", "</Registro>");*/

            GC.Collect();
            return imgPretoBranco;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg)|";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                tempImgFonte = path;
                imgOriginal = new Bitmap(path);
                picBoxCam.Load(path);

                carregar_img.Visible = true;
                abrirCamera.Visible = true;
                foco = false;
                tirarFoto.Visible = false;
                
                fecharCamera();
            }
        }

        private void abrirCamera_Click(object sender, EventArgs e)
        {
            abrir_trocarCamera();
        }

        private void tirar_carregarFoto_Click(object sender, EventArgs e)
        {
            salvarImagem.Visible = true;
            trackBar1.Value = 127;

            tempImgFonte = nomeProjeto + "_imgFonte.jpg";
            imgOriginal = new Bitmap(picBoxCam.Image);
            imgOriginal.Save(tempImgFonte);
            imgProcessada = ProcessarImg(127);
            picBoxImg.Image = imgProcessada;

            label6.Text = (coluna + "x" + linha + "px / " + Pixel_Centimetros(coluna, 'x').ToString("0.00") + "x" + 
                           Pixel_Centimetros(linha, 'y').ToString("0.00") + "cm").ToString();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (picBoxImg.Image == null)
                MessageBox.Show("CARREGUE A IMAGEM");
            else
            {
                imgOriginal = new Bitmap(picBoxCam.Image);
                imgProcessada = ProcessarImg(trackBar1.Value);
                picBoxImg.Image = imgProcessada;
            }
        }

        private void salvarImagem_Click(object sender, EventArgs e)
        {
            tempImgProcessada = nomeProjeto + "_imgPretoBranco.jpg";
            imgProcessada.Save(tempImgProcessada);
            imgProcessada = ProcessarImg(127);
            inserirDados();
        }

        void inserirDados()
        {
            string database = "SERVER=localhost;DATABASE=pdi;UID=root;PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(database);
            MySqlCommand comandosql = connection.CreateCommand();
            connection.Open();

            comandosql.CommandText = String.Format(@"insert into dados_projeto (CODIGO_REL, nome_projeto, imagemOriginal, imagemProcessada, largura, altura, status, 
                                      areaUtil, comentario) 
                                     values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                     this.cpf_cnpj, nomeProjeto, tempImgFonte, tempImgProcessada, coluna, linha, status, areaUtil, comentario);
            comandosql.ExecuteNonQuery();
            comandosql.Connection.Close();
            connection.Close();

            MessageBox.Show("Inserido com sucesso!");
        }

        private void FormImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            fecharCamera();
            //Application.Exit();
        }
    }
}