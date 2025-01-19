namespace AppEscala
{
    partial class UserControl2
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
            txtNome = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            check_semana = new CheckBox();
            check_fimDsmn = new CheckBox();
            listView1 = new ListView();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButton2 = new ReaLTaiizor.Controls.HopeRoundButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(218, 133);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(345, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 133);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Gainsboro;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(427, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 12, 21, 19, 29, 52, 0);
            // 
            // check_semana
            // 
            check_semana.Appearance = Appearance.Button;
            check_semana.AutoSize = true;
            check_semana.FlatAppearance.BorderSize = 0;
            check_semana.FlatAppearance.CheckedBackColor = Color.Transparent;
            check_semana.FlatAppearance.MouseDownBackColor = Color.Transparent;
            check_semana.FlatAppearance.MouseOverBackColor = Color.Transparent;
            check_semana.FlatStyle = FlatStyle.Flat;
            check_semana.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            check_semana.Image = Properties.Resources.Vunchecked;
            check_semana.Location = new Point(78, 203);
            check_semana.Name = "check_semana";
            check_semana.Size = new Size(270, 38);
            check_semana.TabIndex = 8;
            check_semana.Text = "Pode servir durante a semana.";
            check_semana.TextImageRelation = TextImageRelation.ImageBeforeText;
            check_semana.UseVisualStyleBackColor = true;
            check_semana.CheckedChanged += check_semana_CheckedChanged;
            // 
            // check_fimDsmn
            // 
            check_fimDsmn.Appearance = Appearance.Button;
            check_fimDsmn.AutoSize = true;
            check_fimDsmn.FlatAppearance.BorderSize = 0;
            check_fimDsmn.FlatAppearance.CheckedBackColor = Color.Transparent;
            check_fimDsmn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            check_fimDsmn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            check_fimDsmn.FlatStyle = FlatStyle.Flat;
            check_fimDsmn.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold);
            check_fimDsmn.Image = Properties.Resources.Vunchecked;
            check_fimDsmn.Location = new Point(78, 247);
            check_fimDsmn.Name = "check_fimDsmn";
            check_fimDsmn.Size = new Size(279, 38);
            check_fimDsmn.TabIndex = 9;
            check_fimDsmn.Text = "Pode servir no final de semana.";
            check_fimDsmn.TextImageRelation = TextImageRelation.ImageBeforeText;
            check_fimDsmn.UseVisualStyleBackColor = true;
            check_fimDsmn.CheckedChanged += check_fimDsmn_CheckedChanged;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Location = new Point(427, 223);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 97);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(407, 173);
            label3.Name = "label3";
            label3.Size = new Size(232, 18);
            label3.TabIndex = 12;
            label3.Text = "Dias específicos que não pode:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(199, 41);
            label1.Name = "label1";
            label1.Size = new Size(364, 34);
            label1.TabIndex = 0;
            label1.Text = "ADICIONAR ACÓLITOS:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 433);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 39);
            panel3.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GrayText;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(706, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(40, 433);
            panel5.TabIndex = 17;
            // 
            // hopeRoundButton1
            // 
            hopeRoundButton1.BackColor = Color.White;
            hopeRoundButton1.BorderColor = Color.IndianRed;
            hopeRoundButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton1.Location = new Point(247, 348);
            hopeRoundButton1.Name = "hopeRoundButton1";
            hopeRoundButton1.PrimaryColor = Color.White;
            hopeRoundButton1.Size = new Size(200, 44);
            hopeRoundButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton1.TabIndex = 18;
            hopeRoundButton1.Text = "Adicionar Acólito";
            hopeRoundButton1.TextColor = Color.Black;
            hopeRoundButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButton1.Click += hopeRoundButton1_Click;
            // 
            // hopeRoundButton2
            // 
            hopeRoundButton2.BackColor = Color.White;
            hopeRoundButton2.BorderColor = Color.IndianRed;
            hopeRoundButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton2.Location = new Point(527, 325);
            hopeRoundButton2.Name = "hopeRoundButton2";
            hopeRoundButton2.PrimaryColor = Color.White;
            hopeRoundButton2.Size = new Size(100, 24);
            hopeRoundButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton2.TabIndex = 19;
            hopeRoundButton2.Text = "Adicionar";
            hopeRoundButton2.TextColor = Color.Black;
            hopeRoundButton2.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButton2.Click += hopeRoundButton2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(503, 375);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 21;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(materialButton1);
            Controls.Add(hopeRoundButton2);
            Controls.Add(hopeRoundButton1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(check_fimDsmn);
            Controls.Add(check_semana);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Name = "UserControl2";
            Size = new Size(746, 472);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private CheckBox check_semana;
        private CheckBox check_fimDsmn;
        private ListView listView1;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
    }
}
