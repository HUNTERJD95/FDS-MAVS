namespace MAVS_Projeto_Windows_Forms
{
    partial class Registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            this.groupBoxRegisto = new System.Windows.Forms.GroupBox();
            this.checkBoxPasswordRegisto2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPasswordRegisto1 = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelConfirmarPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxRegisto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegisto
            // 
            this.groupBoxRegisto.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegisto.Controls.Add(this.labelNome);
            this.groupBoxRegisto.Controls.Add(this.textBoxNome);
            this.groupBoxRegisto.Controls.Add(this.checkBoxPasswordRegisto2);
            this.groupBoxRegisto.Controls.Add(this.checkBoxPasswordRegisto1);
            this.groupBoxRegisto.Controls.Add(this.textBoxEmail);
            this.groupBoxRegisto.Controls.Add(this.textBoxConfirmarPassword);
            this.groupBoxRegisto.Controls.Add(this.textBoxPassword);
            this.groupBoxRegisto.Controls.Add(this.textBoxUsername);
            this.groupBoxRegisto.Controls.Add(this.buttonConfirmar);
            this.groupBoxRegisto.Controls.Add(this.labelEmail);
            this.groupBoxRegisto.Controls.Add(this.labelConfirmarPassword);
            this.groupBoxRegisto.Controls.Add(this.labelPassword);
            this.groupBoxRegisto.Controls.Add(this.label1);
            this.groupBoxRegisto.Controls.Add(this.labelUsername);
            this.groupBoxRegisto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRegisto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxRegisto.Location = new System.Drawing.Point(37, 27);
            this.groupBoxRegisto.Name = "groupBoxRegisto";
            this.groupBoxRegisto.Size = new System.Drawing.Size(443, 428);
            this.groupBoxRegisto.TabIndex = 0;
            this.groupBoxRegisto.TabStop = false;
            this.groupBoxRegisto.Text = "Criar Utilizador";
            this.groupBoxRegisto.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxPasswordRegisto2
            // 
            this.checkBoxPasswordRegisto2.AutoSize = true;
            this.checkBoxPasswordRegisto2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPasswordRegisto2.Location = new System.Drawing.Point(303, 288);
            this.checkBoxPasswordRegisto2.Name = "checkBoxPasswordRegisto2";
            this.checkBoxPasswordRegisto2.Size = new System.Drawing.Size(140, 23);
            this.checkBoxPasswordRegisto2.TabIndex = 11;
            this.checkBoxPasswordRegisto2.Text = "Mostrar Password";
            this.checkBoxPasswordRegisto2.UseVisualStyleBackColor = true;
            this.checkBoxPasswordRegisto2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBoxPasswordRegisto1
            // 
            this.checkBoxPasswordRegisto1.AutoSize = true;
            this.checkBoxPasswordRegisto1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPasswordRegisto1.Location = new System.Drawing.Point(303, 220);
            this.checkBoxPasswordRegisto1.Name = "checkBoxPasswordRegisto1";
            this.checkBoxPasswordRegisto1.Size = new System.Drawing.Size(140, 23);
            this.checkBoxPasswordRegisto1.TabIndex = 10;
            this.checkBoxPasswordRegisto1.Text = "Mostrar Password";
            this.checkBoxPasswordRegisto1.UseVisualStyleBackColor = true;
            this.checkBoxPasswordRegisto1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(6, 352);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(291, 33);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxConfirmarPassword
            // 
            this.textBoxConfirmarPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxConfirmarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmarPassword.Location = new System.Drawing.Point(6, 282);
            this.textBoxConfirmarPassword.Name = "textBoxConfirmarPassword";
            this.textBoxConfirmarPassword.Size = new System.Drawing.Size(291, 33);
            this.textBoxConfirmarPassword.TabIndex = 8;
            this.textBoxConfirmarPassword.TextChanged += new System.EventHandler(this.textBoxConfirmarPassword_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(6, 214);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(291, 33);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Location = new System.Drawing.Point(6, 146);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(291, 33);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmar.Location = new System.Drawing.Point(350, 386);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(87, 36);
            this.buttonConfirmar.TabIndex = 5;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(6, 330);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 19);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // labelConfirmarPassword
            // 
            this.labelConfirmarPassword.AutoSize = true;
            this.labelConfirmarPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmarPassword.Location = new System.Drawing.Point(3, 260);
            this.labelConfirmarPassword.Name = "labelConfirmarPassword";
            this.labelConfirmarPassword.Size = new System.Drawing.Size(138, 19);
            this.labelConfirmarPassword.TabIndex = 3;
            this.labelConfirmarPassword.Text = "Confirmar Password:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(6, 192);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(71, 19);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(3, 124);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 19);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(6, 76);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(291, 33);
            this.textBoxNome.TabIndex = 12;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(6, 54);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 19);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 481);
            this.Controls.Add(this.groupBoxRegisto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo";
            this.groupBoxRegisto.ResumeLayout(false);
            this.groupBoxRegisto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxRegisto;
        private TextBox textBoxEmail;
        private TextBox textBoxConfirmarPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonConfirmar;
        private Label labelEmail;
        private Label labelConfirmarPassword;
        private Label labelPassword;
        private Label label1;
        private Label labelUsername;
        private CheckBox checkBoxPasswordRegisto1;
        private CheckBox checkBoxPasswordRegisto2;
        private Label labelNome;
        private TextBox textBoxNome;
    }
}