namespace MAVS_Projeto_Windows_Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(273, 170);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(258, 23);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(273, 230);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(258, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(161, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(364, 279);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordCheckBox.Location = new System.Drawing.Point(542, 230);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(137, 24);
            this.passwordCheckBox.TabIndex = 6;
            this.passwordCheckBox.Text = "Show Password";
            this.passwordCheckBox.UseVisualStyleBackColor = false;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.passwordCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(618, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAVS Supply Chain Management";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.Location = new System.Drawing.Point(273, 390);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(239, 21);
            this.registerLabel.TabIndex = 8;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Sem Registo? Cadastre-se agora!";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 441);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private CheckBox passwordCheckBox;
        private Label label3;
        private LinkLabel registerLabel;
    }
}