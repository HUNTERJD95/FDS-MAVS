using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using MAVS_Projeto_Windows_Forms.Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MAVS_Projeto_Windows_Forms
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            setPasswordBox1();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            setPasswordBox1();
        }

        private void textBoxConfirmarPassword_TextChanged(object sender, EventArgs e)
        {
            setPasswordBox2();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            setPasswordBox2();
        }


       // Foram feitas 2 funções para conseguir ver a password na label 'password' e na label 'confirmar password', sendo passwordbox1 a primeira label (password) e setpasswordbox2 a segunda (confirmar)
        private void setPasswordBox1()
        {
            if (checkBoxPasswordRegisto1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void setPasswordBox2()
        {
            if (checkBoxPasswordRegisto2.Checked)
            {
                textBoxConfirmarPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxConfirmarPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // validate

            using (var db = new MAVSContext())
            {
                // insert
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
