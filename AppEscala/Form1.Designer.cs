
namespace AppEscala
{
    partial class form_menu 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            pnMenu = new Panel();
            button1 = new Button();
            MenuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            menu = new Button();
            panel2 = new Panel();
            subMenu1 = new Button();
            panel4 = new Panel();
            subMenu2 = new Button();
            EscalaContainer = new FlowLayoutPanel();
            pnEscala = new Panel();
            btnEscala = new Button();
            panel7 = new Panel();
            button5 = new Button();
            panel8 = new Panel();
            button6 = new Button();
            pnInfo = new Panel();
            button3 = new Button();
            pnConfig = new Panel();
            button2 = new Button();
            button9 = new Button();
            pnLogout = new Panel();
            button8 = new Button();
            timerSideBarTransition = new System.Windows.Forms.Timer(components);
            btnHam = new PictureBox();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            userAcolitos = new userAcolitos();
            EscalaTransition = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            pnMenu.SuspendLayout();
            MenuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            EscalaContainer.SuspendLayout();
            pnEscala.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            pnInfo.SuspendLayout();
            pnConfig.SuspendLayout();
            pnLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuTransition
            // 
            menuTransition.Interval = 7;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.DimGray;
            sidebar.Controls.Add(pnMenu);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(EscalaContainer);
            sidebar.Controls.Add(pnInfo);
            sidebar.Controls.Add(pnConfig);
            sidebar.Controls.Add(pnLogout);
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.ForeColor = Color.Coral;
            sidebar.Location = new Point(0, 37);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(40, 472);
            sidebar.TabIndex = 3;
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(button1);
            pnMenu.Location = new Point(3, 33);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(183, 55);
            pnMenu.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -13);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 15, 0, 0);
            button1.Size = new Size(202, 73);
            button1.TabIndex = 1;
            button1.Text = "       Menu";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = Color.DimGray;
            MenuContainer.Controls.Add(panel3);
            MenuContainer.Controls.Add(panel2);
            MenuContainer.Controls.Add(panel4);
            MenuContainer.Location = new Point(0, 91);
            MenuContainer.Margin = new Padding(0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(2, 0, 0, 0);
            MenuContainer.Size = new Size(186, 58);
            MenuContainer.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 46);
            panel3.TabIndex = 9;
            // 
            // menu
            // 
            menu.BackColor = Color.DimGray;
            menu.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.ForeColor = SystemColors.Control;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-10, -14);
            menu.Name = "menu";
            menu.Padding = new Padding(13, 13, 0, 0);
            menu.Size = new Size(202, 73);
            menu.TabIndex = 1;
            menu.Text = "      Ver Acólitos";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            menu.Click += btnMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(subMenu1);
            panel2.Location = new Point(5, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 40);
            panel2.TabIndex = 8;
            // 
            // subMenu1
            // 
            subMenu1.BackColor = Color.DimGray;
            subMenu1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenu1.ForeColor = SystemColors.Control;
            subMenu1.Image = (Image)resources.GetObject("subMenu1.Image");
            subMenu1.ImageAlign = ContentAlignment.MiddleLeft;
            subMenu1.Location = new Point(-4, -12);
            subMenu1.Margin = new Padding(0);
            subMenu1.Name = "subMenu1";
            subMenu1.Padding = new Padding(8, 5, 5, 5);
            subMenu1.Size = new Size(202, 71);
            subMenu1.TabIndex = 1;
            subMenu1.Text = "     Acólitos";
            subMenu1.TextAlign = ContentAlignment.MiddleLeft;
            subMenu1.UseVisualStyleBackColor = false;
            subMenu1.Click += subMenu1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(subMenu2);
            panel4.Location = new Point(5, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 40);
            panel4.TabIndex = 9;
            // 
            // subMenu2
            // 
            subMenu2.BackColor = Color.DimGray;
            subMenu2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenu2.ForeColor = SystemColors.Control;
            subMenu2.Image = (Image)resources.GetObject("subMenu2.Image");
            subMenu2.ImageAlign = ContentAlignment.MiddleLeft;
            subMenu2.Location = new Point(-4, -12);
            subMenu2.Margin = new Padding(0);
            subMenu2.Name = "subMenu2";
            subMenu2.Padding = new Padding(8, 5, 5, 5);
            subMenu2.Size = new Size(202, 73);
            subMenu2.TabIndex = 1;
            subMenu2.Text = "     Adicionar Acólitos";
            subMenu2.TextAlign = ContentAlignment.MiddleLeft;
            subMenu2.UseVisualStyleBackColor = false;
            subMenu2.Click += subMenu2_Click;
            // 
            // EscalaContainer
            // 
            EscalaContainer.BackColor = Color.DimGray;
            EscalaContainer.Controls.Add(pnEscala);
            EscalaContainer.Controls.Add(panel7);
            EscalaContainer.Controls.Add(panel8);
            EscalaContainer.Location = new Point(0, 149);
            EscalaContainer.Margin = new Padding(0);
            EscalaContainer.Name = "EscalaContainer";
            EscalaContainer.Padding = new Padding(2, 0, 0, 0);
            EscalaContainer.Size = new Size(186, 57);
            EscalaContainer.TabIndex = 13;
            // 
            // pnEscala
            // 
            pnEscala.Controls.Add(btnEscala);
            pnEscala.Location = new Point(5, 3);
            pnEscala.Name = "pnEscala";
            pnEscala.Size = new Size(189, 40);
            pnEscala.TabIndex = 9;
            // 
            // btnEscala
            // 
            btnEscala.BackColor = Color.DimGray;
            btnEscala.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscala.ForeColor = SystemColors.Control;
            btnEscala.Image = (Image)resources.GetObject("btnEscala.Image");
            btnEscala.ImageAlign = ContentAlignment.MiddleLeft;
            btnEscala.Location = new Point(-10, -13);
            btnEscala.Name = "btnEscala";
            btnEscala.Padding = new Padding(13, 5, 0, 0);
            btnEscala.Size = new Size(202, 73);
            btnEscala.TabIndex = 1;
            btnEscala.Text = "      Escalas";
            btnEscala.TextAlign = ContentAlignment.MiddleLeft;
            btnEscala.UseVisualStyleBackColor = false;
            btnEscala.Click += btnEscala_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button5);
            panel7.Location = new Point(5, 49);
            panel7.Name = "panel7";
            panel7.Size = new Size(186, 40);
            panel7.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-4, -12);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(8, 5, 5, 5);
            button5.Size = new Size(202, 71);
            button5.TabIndex = 1;
            button5.Text = "     AlgumaCoisa";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button6);
            panel8.Location = new Point(5, 95);
            panel8.Name = "panel8";
            panel8.Size = new Size(186, 40);
            panel8.TabIndex = 9;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Control;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-4, -12);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(8, 5, 5, 5);
            button6.Size = new Size(202, 73);
            button6.TabIndex = 1;
            button6.Text = "     AlgumaCoisa";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(button3);
            pnInfo.Location = new Point(3, 209);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(183, 55);
            pnInfo.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-12, -11);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(18, 5, 5, 5);
            button3.Size = new Size(201, 70);
            button3.TabIndex = 1;
            button3.Text = "      Informações";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // pnConfig
            // 
            pnConfig.Controls.Add(button2);
            pnConfig.Controls.Add(button9);
            pnConfig.Location = new Point(3, 270);
            pnConfig.Name = "pnConfig";
            pnConfig.Size = new Size(183, 55);
            pnConfig.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-10, -8);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(14, 5, 5, 5);
            button2.Size = new Size(202, 71);
            button2.TabIndex = 2;
            button2.Text = "      Configurações";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.Control;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-10, -12);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Padding = new Padding(14, 5, 5, 5);
            button9.Size = new Size(202, 71);
            button9.TabIndex = 1;
            button9.Text = "      Configurações";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(button8);
            pnLogout.Location = new Point(3, 331);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(183, 55);
            pnLogout.TabIndex = 8;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.Control;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-10, -12);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(15, 5, 5, 5);
            button8.Size = new Size(202, 71);
            button8.TabIndex = 1;
            button8.Text = "      Sair";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // timerSideBarTransition
            // 
            timerSideBarTransition.Interval = 7;
            timerSideBarTransition.Tick += timerSideBarTransition_Tick;
            // 
            // btnHam
            // 
            btnHam.BackgroundImageLayout = ImageLayout.Zoom;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(0, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(40, 33);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 3;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 4;
            label1.Text = "CRIAR ESCALAS";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(637, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 39);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(33, 37);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(746, 472);
            userControl11.TabIndex = 5;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(33, 37);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(743, 472);
            userControl21.TabIndex = 6;
            // 
            // userAcolitos
            // 
            userAcolitos.Location = new Point(33, 37);
            userAcolitos.Name = "userAcolitos";
            userAcolitos.Size = new Size(746, 472);
            userAcolitos.TabIndex = 8;
            // 
            // EscalaTransition
            // 
            EscalaTransition.Interval = 7;
            EscalaTransition.Tick += EscalaTransition_Tick;
            // 
            // form_menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(776, 505);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Controls.Add(userAcolitos);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "form_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosed += sub1_FormClosed;
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            EscalaContainer.ResumeLayout(false);
            pnEscala.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
            pnConfig.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer menuTransition;
        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel MenuContainer;
        private Panel panel3;
        private Button menu;
        private Panel panel2;
        private Button subMenu1;
        private Panel panel4;
        private Button subMenu2;
        private Panel pnLogout;
        private Button button8;
        private Panel pnConfig;
        private Button button9;
        private System.Windows.Forms.Timer timerSideBarTransition;
        private PictureBox btnHam;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private Button button2;
        private Panel pnInfo;
        private Button button3;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private userAcolitos userAcolitos;
        private Missas missas1;
        private Panel pnMenu;
        private Button button1;
        private FlowLayoutPanel EscalaContainer;
        private Panel pnEscala;
        private Button btnEscala;
        private Panel panel7;
        private Button button5;
        private Panel panel8;
        private Button button6;
        private System.Windows.Forms.Timer EscalaTransition;
    }
}
