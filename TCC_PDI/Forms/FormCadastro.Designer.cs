
namespace TCC_PDI
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomeEmpresa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnCNPJ = new System.Windows.Forms.RadioButton();
            this.radiobtnCPF = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoginBack = new FontAwesome.Sharp.IconButton();
            this.textSenha = new System.Windows.Forms.MaskedTextBox();
            this.textCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxRamoAtividade = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 523);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(490, 55);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF / CNPJ";
            // 
            // textNomeEmpresa
            // 
            this.textNomeEmpresa.Location = new System.Drawing.Point(12, 239);
            this.textNomeEmpresa.Name = "textNomeEmpresa";
            this.textNomeEmpresa.Size = new System.Drawing.Size(417, 27);
            this.textNomeEmpresa.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.cmbBoxRamoAtividade);
            this.panel1.Controls.Add(this.radioBtnCNPJ);
            this.panel1.Controls.Add(this.radiobtnCPF);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.iconPictureBox5);
            this.panel1.Controls.Add(this.iconPictureBox4);
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.textNomeEmpresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 751);
            this.panel1.TabIndex = 4;
            // 
            // radioBtnCNPJ
            // 
            this.radioBtnCNPJ.AutoSize = true;
            this.radioBtnCNPJ.Location = new System.Drawing.Point(77, 169);
            this.radioBtnCNPJ.Name = "radioBtnCNPJ";
            this.radioBtnCNPJ.Size = new System.Drawing.Size(62, 24);
            this.radioBtnCNPJ.TabIndex = 11;
            this.radioBtnCNPJ.TabStop = true;
            this.radioBtnCNPJ.Text = "CNPJ";
            this.radioBtnCNPJ.UseVisualStyleBackColor = true;
            this.radioBtnCNPJ.CheckedChanged += new System.EventHandler(this.radioBtnCNPJ_CheckedChanged);
            // 
            // radiobtnCPF
            // 
            this.radiobtnCPF.AutoSize = true;
            this.radiobtnCPF.Checked = true;
            this.radiobtnCPF.Location = new System.Drawing.Point(12, 169);
            this.radiobtnCPF.Name = "radiobtnCPF";
            this.radiobtnCPF.Size = new System.Drawing.Size(54, 24);
            this.radiobtnCPF.TabIndex = 11;
            this.radiobtnCPF.TabStop = true;
            this.radiobtnCPF.Text = "CPF";
            this.radiobtnCPF.UseVisualStyleBackColor = true;
            this.radiobtnCPF.CheckedChanged += new System.EventHandler(this.radiobtnCPF_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 477);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 65;
            this.iconPictureBox5.Location = new System.Drawing.Point(435, 321);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(67, 65);
            this.iconPictureBox5.TabIndex = 9;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox4.IconColor = System.Drawing.Color.White;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 60;
            this.iconPictureBox4.Location = new System.Drawing.Point(435, 430);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(67, 60);
            this.iconPictureBox4.TabIndex = 8;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 65;
            this.iconPictureBox3.Location = new System.Drawing.Point(435, 216);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(67, 65);
            this.iconPictureBox3.TabIndex = 7;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 65;
            this.iconPictureBox2.Location = new System.Drawing.Point(435, 122);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(67, 65);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ramo / Atividade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome da Empresa";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(203, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 72);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(550, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(550, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Já possui uma conta?";
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.FlatAppearance.BorderSize = 0;
            this.btnLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoginBack.ForeColor = System.Drawing.Color.Red;
            this.btnLoginBack.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoginBack.IconColor = System.Drawing.Color.Red;
            this.btnLoginBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginBack.Location = new System.Drawing.Point(729, 705);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(143, 29);
            this.btnLoginBack.TabIndex = 7;
            this.btnLoginBack.Text = "Faça Login";
            this.btnLoginBack.UseVisualStyleBackColor = true;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(12, 443);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(417, 27);
            this.textSenha.TabIndex = 8;
            // 
            // textCPF_CNPJ
            // 
            this.textCPF_CNPJ.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textCPF_CNPJ.Location = new System.Drawing.Point(12, 136);
            this.textCPF_CNPJ.Name = "textCPF_CNPJ";
            this.textCPF_CNPJ.Size = new System.Drawing.Size(417, 27);
            this.textCPF_CNPJ.TabIndex = 14;
            this.textCPF_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textCPF_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCPF_CNPJ_KeyPress);
            // 
            // cmbBoxRamoAtividade
            // 
            this.cmbBoxRamoAtividade.FormattingEnabled = true;
            this.cmbBoxRamoAtividade.Location = new System.Drawing.Point(12, 344);
            this.cmbBoxRamoAtividade.Name = "cmbBoxRamoAtividade";
            this.cmbBoxRamoAtividade.Size = new System.Drawing.Size(417, 28);
            this.cmbBoxRamoAtividade.TabIndex = 15;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 751);
            this.Controls.Add(this.textCPF_CNPJ);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.btnLoginBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModal";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomeEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnLoginBack;
        private System.Windows.Forms.MaskedTextBox textSenha;
        private System.Windows.Forms.MaskedTextBox textCPF_CNPJ;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioBtnCNPJ;
        private System.Windows.Forms.RadioButton radiobtnCPF;
        private System.Windows.Forms.ComboBox cmbBoxRamoAtividade;
    }
}