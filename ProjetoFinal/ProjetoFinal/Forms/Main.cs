using System;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toggle_mostrar_senha_ToggledChanged()
        {
            if(toggle_mostrar_senha.Toggled == true)
            {
                txt_passwd.UseSystemPasswordChar = false;
            } else
            {
                txt_passwd.UseSystemPasswordChar = true;
            }
        }

        private void txt_entrar_Click(object sender, EventArgs e)
        {
            if (txt_usr.Text == "Alunos" && txt_passwd.Text == "aluno") {
                Aluno form_open = new Aluno();
                form_open.Show();
                this.Hide();
            } else if (txt_usr.Text == "Docente" && txt_passwd.Text == "senha123") {
                Docente form_open = new Docente();
                form_open.Show();
                this.Hide();
            } else if (txt_usr.Text == "Secretaria" && txt_passwd.Text == "admin123") {
                Secretaria form_open = new Secretaria();
                form_open.Show();
                this.Hide();
            } else {
                MessageBox.Show("Login Inválido!");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void txt_usr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_passwd.Text == "")
            {
                txt_passwd.Focus();
            }
        }

        private void txt_passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_entrar_Click(this, new EventArgs());
            }
        }
    }
}
