
namespace TCC_PDI.Forms
{
    partial class FormImage
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
            this.components = new System.ComponentModel.Container();
            this.picBoxCam = new System.Windows.Forms.PictureBox();
            this.carregar_img = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salvarImagem = new System.Windows.Forms.Button();
            this.abrirCamera = new System.Windows.Forms.Button();
            this.tirarFoto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxComentario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCam
            // 
            this.picBoxCam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCam.Location = new System.Drawing.Point(185, 103);
            this.picBoxCam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxCam.Name = "picBoxCam";
            this.picBoxCam.Size = new System.Drawing.Size(340, 236);
            this.picBoxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCam.TabIndex = 0;
            this.picBoxCam.TabStop = false;
            this.picBoxCam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // carregar_img
            // 
            this.carregar_img.Location = new System.Drawing.Point(553, 75);
            this.carregar_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carregar_img.Name = "carregar_img";
            this.carregar_img.Size = new System.Drawing.Size(340, 23);
            this.carregar_img.TabIndex = 1;
            this.carregar_img.Text = "Carregar";
            this.carregar_img.UseVisualStyleBackColor = true;
            this.carregar_img.Visible = false;
            this.carregar_img.Click += new System.EventHandler(this.tirar_carregarFoto_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(553, 343);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(340, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 127;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxImg
            // 
            this.picBoxImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImg.Location = new System.Drawing.Point(553, 103);
            this.picBoxImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(340, 236);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImg.TabIndex = 0;
            this.picBoxImg.TabStop = false;
            // 
            // cmbCameras
            // 
            this.cmbCameras.DisplayMember = "null";
            this.cmbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(185, 343);
            this.cmbCameras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(340, 23);
            this.cmbCameras.TabIndex = 4;
            this.cmbCameras.ValueMember = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Área ocupada: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(488, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(185, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status de utilização de espaço: ";
            // 
            // salvarImagem
            // 
            this.salvarImagem.Location = new System.Drawing.Point(913, 337);
            this.salvarImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salvarImagem.Name = "salvarImagem";
            this.salvarImagem.Size = new System.Drawing.Size(158, 48);
            this.salvarImagem.TabIndex = 9;
            this.salvarImagem.Text = "Salvar Imagem";
            this.salvarImagem.UseVisualStyleBackColor = true;
            this.salvarImagem.Visible = false;
            this.salvarImagem.Click += new System.EventHandler(this.salvarImagem_Click);
            // 
            // abrirCamera
            // 
            this.abrirCamera.Location = new System.Drawing.Point(185, 75);
            this.abrirCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abrirCamera.Name = "abrirCamera";
            this.abrirCamera.Size = new System.Drawing.Size(163, 23);
            this.abrirCamera.TabIndex = 10;
            this.abrirCamera.Text = "Abrir Câmera";
            this.abrirCamera.UseVisualStyleBackColor = true;
            this.abrirCamera.Click += new System.EventHandler(this.abrirCamera_Click);
            // 
            // tirarFoto
            // 
            this.tirarFoto.Location = new System.Drawing.Point(185, 75);
            this.tirarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tirarFoto.Name = "tirarFoto";
            this.tirarFoto.Size = new System.Drawing.Size(340, 23);
            this.tirarFoto.TabIndex = 11;
            this.tirarFoto.Text = "Tirar Foto";
            this.tirarFoto.UseVisualStyleBackColor = true;
            this.tirarFoto.Visible = false;
            this.tirarFoto.Click += new System.EventHandler(this.tirar_carregarFoto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(606, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Limiarização da Imagem";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // txtBoxComentario
            // 
            this.txtBoxComentario.Location = new System.Drawing.Point(933, 103);
            this.txtBoxComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxComentario.Multiline = true;
            this.txtBoxComentario.Name = "txtBoxComentario";
            this.txtBoxComentario.Size = new System.Drawing.Size(138, 176);
            this.txtBoxComentario.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(945, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Comentário";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 546);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxComentario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tirarFoto);
            this.Controls.Add(this.abrirCamera);
            this.Controls.Add(this.salvarImagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCameras);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.carregar_img);
            this.Controls.Add(this.picBoxImg);
            this.Controls.Add(this.picBoxCam);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormImage";
            this.Text = "FormImage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImage_FormClosing);
            this.Load += new System.EventHandler(this.FormImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCam;
        private System.Windows.Forms.Button carregar_img;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBoxImg;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salvarImagem;
        private System.Windows.Forms.Button abrirCamera;
        private System.Windows.Forms.Button tirarFoto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxComentario;
        private System.Windows.Forms.Label label7;
    }
}