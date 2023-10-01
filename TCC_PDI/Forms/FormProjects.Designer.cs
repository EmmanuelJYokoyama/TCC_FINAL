
namespace TCC_PDI.Forms
{
    partial class FormProjects
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
            this.grid_projetos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_projetos)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_projetos
            // 
            this.grid_projetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_projetos.Location = new System.Drawing.Point(67, 72);
            this.grid_projetos.Name = "grid_projetos";
            this.grid_projetos.RowTemplate.Height = 25;
            this.grid_projetos.Size = new System.Drawing.Size(1065, 474);
            this.grid_projetos.TabIndex = 0;
            this.grid_projetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEUS PROJETOS";
            // 
            // FormProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_projetos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProjects";
            this.Text = "FormProjects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProjects_FormClosing);
            this.Load += new System.EventHandler(this.FormProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_projetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_projetos;
        private System.Windows.Forms.Label label1;
    }
}