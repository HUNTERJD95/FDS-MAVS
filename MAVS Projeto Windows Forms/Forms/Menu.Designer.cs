namespace MAVS_Projeto_Windows_Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonSairMenu = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.pictureBoxFuncionarios = new System.Windows.Forms.PictureBox();
            this.pictureBoxProdutos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Location = new System.Drawing.Point(211, 44);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(202, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // buttonSairMenu
            // 
            this.buttonSairMenu.BackColor = System.Drawing.Color.White;
            this.buttonSairMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSairMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSairMenu.Location = new System.Drawing.Point(566, 398);
            this.buttonSairMenu.Name = "buttonSairMenu";
            this.buttonSairMenu.Size = new System.Drawing.Size(149, 40);
            this.buttonSairMenu.TabIndex = 1;
            this.buttonSairMenu.Text = "Terminar Sessão";
            this.buttonSairMenu.UseVisualStyleBackColor = false;
            this.buttonSairMenu.Click += new System.EventHandler(this.buttonSairMenu_Click);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.Location = new System.Drawing.Point(90, 298);
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.Size = new System.Drawing.Size(145, 59);
            this.buttonFuncionarios.TabIndex = 2;
            this.buttonFuncionarios.Text = "Funcionários";
            this.buttonFuncionarios.UseVisualStyleBackColor = true;
            this.buttonFuncionarios.Click += new System.EventHandler(this.buttonFuncionarios_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.Location = new System.Drawing.Point(489, 298);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(145, 59);
            this.buttonProdutos.TabIndex = 3;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = true;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // pictureBoxFuncionarios
            // 
            this.pictureBoxFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFuncionarios.Image")));
            this.pictureBoxFuncionarios.Location = new System.Drawing.Point(33, 51);
            this.pictureBoxFuncionarios.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFuncionarios.Name = "pictureBoxFuncionarios";
            this.pictureBoxFuncionarios.Size = new System.Drawing.Size(273, 244);
            this.pictureBoxFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFuncionarios.TabIndex = 4;
            this.pictureBoxFuncionarios.TabStop = false;
            // 
            // pictureBoxProdutos
            // 
            this.pictureBoxProdutos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProdutos.Image")));
            this.pictureBoxProdutos.Location = new System.Drawing.Point(416, 71);
            this.pictureBoxProdutos.Name = "pictureBoxProdutos";
            this.pictureBoxProdutos.Size = new System.Drawing.Size(273, 200);
            this.pictureBoxProdutos.TabIndex = 5;
            this.pictureBoxProdutos.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.pictureBoxProdutos);
            this.Controls.Add(this.pictureBoxFuncionarios);
            this.Controls.Add(this.buttonProdutos);
            this.Controls.Add(this.buttonFuncionarios);
            this.Controls.Add(this.buttonSairMenu);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private Button buttonSairMenu;
        private Button buttonFuncionarios;
        private Button buttonProdutos;
        private PictureBox pictureBoxFuncionarios;
        private PictureBox pictureBoxProdutos;
    }
}