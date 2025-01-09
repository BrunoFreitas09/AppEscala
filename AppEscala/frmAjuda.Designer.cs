namespace AppEscala
{
    partial class frmAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjuda));
            panel3 = new Panel();
            menu = new Button();
            MenuContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            subMenu1 = new Button();
            panel4 = new Panel();
            subMenu2 = new Button();
            panel3.SuspendLayout();
            MenuContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(menu);
            panel3.Location = new Point(82, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 56);
            panel3.TabIndex = 9;
            // 
            // menu
            // 
            menu.BackColor = Color.Black;
            menu.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.ForeColor = SystemColors.Control;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-10, -13);
            menu.Name = "menu";
            menu.Padding = new Padding(13, 5, 0, 0);
            menu.Size = new Size(202, 73);
            menu.TabIndex = 1;
            menu.Text = "      Menu";
            menu.TextAlign = ContentAlignment.MiddleLeft;
            menu.UseVisualStyleBackColor = false;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = SystemColors.ActiveCaptionText;
            MenuContainer.Controls.Add(panel1);
            MenuContainer.Controls.Add(panel2);
            MenuContainer.Controls.Add(panel4);
            MenuContainer.Location = new Point(307, 148);
            MenuContainer.Margin = new Padding(0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Padding = new Padding(2, 0, 0, 0);
            MenuContainer.Size = new Size(186, 56);
            MenuContainer.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 40);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-10, -13);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 5, 0, 0);
            button1.Size = new Size(202, 73);
            button1.TabIndex = 1;
            button1.Text = "      Escala";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(subMenu1);
            panel2.Location = new Point(5, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 40);
            panel2.TabIndex = 8;
            // 
            // subMenu1
            // 
            subMenu1.BackColor = Color.Black;
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
            subMenu1.Text = "     AlgumaCoisa";
            subMenu1.TextAlign = ContentAlignment.MiddleLeft;
            subMenu1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(subMenu2);
            panel4.Location = new Point(5, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 40);
            panel4.TabIndex = 9;
            // 
            // subMenu2
            // 
            subMenu2.BackColor = Color.Black;
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
            subMenu2.Text = "     AlgumaCoisa";
            subMenu2.TextAlign = ContentAlignment.MiddleLeft;
            subMenu2.UseVisualStyleBackColor = false;
            // 
            // frmAjuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuContainer);
            Controls.Add(panel3);
            Name = "frmAjuda";
            Text = "frmAjuda";
            panel3.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button menu;
        private FlowLayoutPanel MenuContainer;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button subMenu1;
        private Panel panel4;
        private Button subMenu2;
    }
}