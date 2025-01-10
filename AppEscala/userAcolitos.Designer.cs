namespace AppEscala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAcolitos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            groupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_acolitos).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.Location = new Point(236, 48);
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(385, 20);
            txtPesquisa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 45);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 3;
            label2.Text = "PESQUISAR ACÓLITO:";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.Gray;
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(639, 48);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(41, 20);
            btn_buscar.TabIndex = 4;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dgv_acolitos
            // 
            dgv_acolitos.AllowUserToDeleteRows = false;
            dgv_acolitos.AllowUserToOrderColumns = true;
            dgv_acolitos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_acolitos.BackgroundColor = Color.DimGray;
            dgv_acolitos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_acolitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_acolitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_acolitos.Columns.AddRange(new DataGridViewColumn[] { nome, segunda, terca, quarta, quinta, sexta, sabado, domingo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_acolitos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_acolitos.EnableHeadersVisualStyles = false;
            dgv_acolitos.Location = new Point(34, 121);
            dgv_acolitos.Name = "dgv_acolitos";
            dgv_acolitos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_acolitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.DarkGray;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv_acolitos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_acolitos.Size = new Size(646, 203);
            dgv_acolitos.TabIndex = 5;
            dgv_acolitos.CellContentClick += dgv_acolitos_CellContentClick;
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
            // groupBox
            // 
            groupBox.Controls.Add(dgv_acolitos);
            groupBox.Controls.Add(btn_buscar);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(txtPesquisa);
            groupBox.Location = new Point(12, 42);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(720, 377);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            // 
            // userAcolitos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(groupBox);
            Name = "userAcolitos";
            Size = new Size(746, 472);
            Load += acolitos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_acolitos).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private GroupBox groupBox;
    }
}
