﻿namespace AppEscala
{
    partial class userAcolitos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPesquisa = new TextBox();
            label2 = new Label();
            btn_buscar = new Button();
            dgv_acolitos = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            segunda = new DataGridViewTextBoxColumn();
            terca = new DataGridViewTextBoxColumn();
            quarta = new DataGridViewTextBoxColumn();
            quinta = new DataGridViewTextBoxColumn();
            sexta = new DataGridViewTextBoxColumn();
            sabado = new DataGridViewTextBoxColumn();
            domingo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_acolitos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 17);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 1;
            label1.Text = "Acólitos:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(166, 54);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(385, 23);
            txtPesquisa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 57);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 3;
            label2.Text = "Pesquisar Acólito:";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(557, 54);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(78, 24);
            btn_buscar.TabIndex = 4;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dgv_acolitos
            // 
            dgv_acolitos.AllowUserToAddRows = false;
            dgv_acolitos.AllowUserToDeleteRows = false;
            dgv_acolitos.AllowUserToOrderColumns = true;
            dgv_acolitos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_acolitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_acolitos.Columns.AddRange(new DataGridViewColumn[] { nome, segunda, terca, quarta, quinta, sexta, sabado, domingo });
            dgv_acolitos.Location = new Point(48, 122);
            dgv_acolitos.Name = "dgv_acolitos";
            dgv_acolitos.ReadOnly = true;
            dgv_acolitos.Size = new Size(646, 203);
            dgv_acolitos.TabIndex = 5;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 155;
            // 
            // segunda
            // 
            segunda.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            segunda.HeaderText = "Segunda";
            segunda.Name = "segunda";
            segunda.ReadOnly = true;
            // 
            // terca
            // 
            terca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            terca.HeaderText = "Terça";
            terca.Name = "terca";
            terca.ReadOnly = true;
            // 
            // quarta
            // 
            quarta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quarta.HeaderText = "Quarta";
            quarta.Name = "quarta";
            quarta.ReadOnly = true;
            // 
            // quinta
            // 
            quinta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quinta.HeaderText = "Quinta";
            quinta.Name = "quinta";
            quinta.ReadOnly = true;
            // 
            // sexta
            // 
            sexta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sexta.HeaderText = "Sexta";
            sexta.Name = "sexta";
            sexta.ReadOnly = true;
            // 
            // sabado
            // 
            sabado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sabado.HeaderText = "Sábado";
            sabado.Name = "sabado";
            sabado.ReadOnly = true;
            // 
            // domingo
            // 
            domingo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            domingo.HeaderText = "Domingo";
            domingo.Name = "domingo";
            domingo.ReadOnly = true;
            // 
            // userAcolitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv_acolitos);
            Controls.Add(btn_buscar);
            Controls.Add(label2);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Name = "userAcolitos";
            Size = new Size(746, 472);
            Load += acolitos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_acolitos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtPesquisa;
        private Label label2;
        private Button btn_buscar;
        private DataGridView dgv_acolitos;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn segunda;
        private DataGridViewTextBoxColumn terca;
        private DataGridViewTextBoxColumn quarta;
        private DataGridViewTextBoxColumn quinta;
        private DataGridViewTextBoxColumn sexta;
        private DataGridViewTextBoxColumn sabado;
        private DataGridViewTextBoxColumn domingo;
    }
}
