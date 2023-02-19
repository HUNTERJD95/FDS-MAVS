namespace MAVS_Projeto_Windows_Forms
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.labelProdutos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabVirtuais = new System.Windows.Forms.TabControl();
            this.Virtuais = new System.Windows.Forms.TabPage();
            this.Fisicos = new System.Windows.Forms.TabPage();
            this.buttonVoltarProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabVirtuais.SuspendLayout();
            this.Virtuais.SuspendLayout();
            this.Fisicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProdutos
            // 
            this.labelProdutos.AutoSize = true;
            this.labelProdutos.BackColor = System.Drawing.Color.Transparent;
            this.labelProdutos.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProdutos.ForeColor = System.Drawing.Color.Black;
            this.labelProdutos.Location = new System.Drawing.Point(301, 9);
            this.labelProdutos.Name = "labelProdutos";
            this.labelProdutos.Size = new System.Drawing.Size(143, 40);
            this.labelProdutos.TabIndex = 0;
            this.labelProdutos.Text = "Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(693, 308);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(697, 312);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabVirtuais
            // 
            this.tabVirtuais.Controls.Add(this.Virtuais);
            this.tabVirtuais.Controls.Add(this.Fisicos);
            this.tabVirtuais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabVirtuais.Location = new System.Drawing.Point(12, 52);
            this.tabVirtuais.Name = "tabVirtuais";
            this.tabVirtuais.SelectedIndex = 0;
            this.tabVirtuais.Size = new System.Drawing.Size(701, 336);
            this.tabVirtuais.TabIndex = 5;
            this.tabVirtuais.Tag = "";
            // 
            // Virtuais
            // 
            this.Virtuais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Virtuais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Virtuais.Controls.Add(this.dataGridView1);
            this.Virtuais.Location = new System.Drawing.Point(4, 30);
            this.Virtuais.Name = "Virtuais";
            this.Virtuais.Padding = new System.Windows.Forms.Padding(3);
            this.Virtuais.Size = new System.Drawing.Size(693, 302);
            this.Virtuais.TabIndex = 0;
            this.Virtuais.Text = "Virtuais";
            this.Virtuais.UseVisualStyleBackColor = true;
            // 
            // Fisicos
            // 
            this.Fisicos.Controls.Add(this.dataGridView2);
            this.Fisicos.Location = new System.Drawing.Point(4, 30);
            this.Fisicos.Name = "Fisicos";
            this.Fisicos.Padding = new System.Windows.Forms.Padding(3);
            this.Fisicos.Size = new System.Drawing.Size(693, 302);
            this.Fisicos.TabIndex = 1;
            this.Fisicos.Text = "Físicos";
            this.Fisicos.UseVisualStyleBackColor = true;
            // 
            // buttonVoltarProdutos
            // 
            this.buttonVoltarProdutos.Location = new System.Drawing.Point(325, 398);
            this.buttonVoltarProdutos.Name = "buttonVoltarProdutos";
            this.buttonVoltarProdutos.Size = new System.Drawing.Size(95, 36);
            this.buttonVoltarProdutos.TabIndex = 6;
            this.buttonVoltarProdutos.Text = "Voltar";
            this.buttonVoltarProdutos.UseVisualStyleBackColor = true;
            this.buttonVoltarProdutos.Click += new System.EventHandler(this.buttonVoltarProdutos_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 446);
            this.Controls.Add(this.buttonVoltarProdutos);
            this.Controls.Add(this.tabVirtuais);
            this.Controls.Add(this.labelProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabVirtuais.ResumeLayout(false);
            this.Virtuais.ResumeLayout(false);
            this.Fisicos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelProdutos;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private TabControl tabVirtuais;
        private TabPage Virtuais;
        private TabPage Fisicos;
        private Button buttonVoltarProdutos;
    }
}