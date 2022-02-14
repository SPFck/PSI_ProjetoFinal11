using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{

    public partial class Secretaria : Form
    {
        private string selected_name, selected_name2, selected_name3, selected_name4 = "";
        public void updateAlunos()
        {
            var bindingList = new BindingList<Aluno_o>(Dados.List_Alunos);
            var source = new BindingSource(bindingList, null);
            alunos_gridview.DataSource = source;
            alunos2_gridview.DataSource = source;
        }
        public void updateProfessores()
        {
            var bindingList = new BindingList<Professor>(Dados.List_professores);
            var source = new BindingSource(bindingList, null);
            gridview_professores.DataSource = source;
        }
        public void updateDisciplinas()
        {
            var bindingList = new BindingList<Disciplina_o>(Dados.List_disciplinas);
            var source = new BindingSource(bindingList, null);
            gridview_disciplinas.DataSource = source;
        }
        public void updateCLD()
        {
            txt_disciplina_professor.Items.Clear();
            Dados.List_disciplinas.ForEach(p => txt_disciplina_professor.Items.Add(p.Nome));
        }

        public Secretaria()
        {
            InitializeComponent();
            updateAlunos();
            updateProfessores();
            updateDisciplinas();
        }

        private Main _mainMenu = new Main();
        private void add_aluno_Click(object sender, EventArgs e)
        {
            Aluno_o t = new Aluno_o(txt_usr_aluno.Text, txt_email_aluno.Text, Convert.ToInt32(txt_idade_aluno.Text), "Inscrito");
            Dados.List_Alunos.Add(t);
            foreach(var x in Dados.List_disciplinas)
            {
                for(int i = 1; i != x.Modulos+1; i++)
                {
                    Dados.List_Modulos.Add(new Modulo(txt_usr_aluno.Text, $"M{i}", x.Nome, 0));
                }
            }
            updateAlunos();
            MessageBox.Show("Aluno adicionado com sucesso!");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Close();
        }

        private void alunos_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_name = alunos_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show($"O aluno {selected_name} foi selecionado!");
        }

        private void aluno_remover_Click(object sender, EventArgs e)
        {
            Dados.List_Alunos.RemoveAll(p => p.Nome == selected_name);
            selected_name = "";
            updateAlunos();
            MessageBox.Show("Aluno removido com sucesso!");
        }

        private void adicionar_professor_Click(object sender, EventArgs e)
        {
            Professor t = new Professor(txt_nome_professor.Text, txt_email_professor.Text, txt_disciplina_professor.SelectedItem.ToString());
            Dados.List_professores.Add(t);
            updateProfessores();
            MessageBox.Show("Professor adicionado com sucesso!");
        }

        private void gridview_professores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_name2 = gridview_professores.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show($"O professor {selected_name2} foi selecionado!");
        }

        private void remover_professor_Click(object sender, EventArgs e)
        {
            Dados.List_professores.RemoveAll(p => p.Nome == selected_name2);
            selected_name2 = "";
            updateProfessores();
            MessageBox.Show("Professor removido com sucesso!");
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            Dados.List_Alunos.FirstOrDefault(p => p.Nome == selected_name3).Estado = "Inscrito";
            updateAlunos();
            MessageBox.Show("Aluno inscrito com sucesso!");
        }

        private void btn_add_disciplina_Click(object sender, EventArgs e)
        {
            Disciplina_o t = new Disciplina_o(txt_nome_disciplina.Text, Convert.ToInt32(txt_n_modulos_disciplina.Text));
            Dados.List_disciplinas.Add(t);
            updateDisciplinas();
            updateCLD();
            MessageBox.Show("Disciplina adicionada com sucesso!");
        }

        private void gridview_disciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_name4 = gridview_disciplinas.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show($"O aluno {selected_name4} foi selecionado!");
        }

        private void btn_remover_disciplina_Click(object sender, EventArgs e)
        {
            Dados.List_professores.RemoveAll(p => p.Nome == selected_name4);
            selected_name4 = "";
            updateDisciplinas();
            updateCLD();
            MessageBox.Show("Disciplina removida com sucesso!");
        }

        private void btn_desin_Click(object sender, EventArgs e)
        {
            Dados.List_Alunos.FirstOrDefault(p => p.Nome == selected_name3).Estado = "Não Inscrito";
            updateAlunos();
            MessageBox.Show("Aluno desinscrito com sucesso!");
        }

        private void alunos2_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_name3 = alunos2_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show($"O aluno {selected_name3} foi selecionado!");
        }
    }
}
