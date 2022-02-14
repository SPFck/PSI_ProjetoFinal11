using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Docente : Form
    {
        private string selected_name = "";
        public void updateAlunos()
        {
            var bindingList = new BindingList<Modulo>(Dados.List_Modulos).Where(p => p.Disciplina == lista_disciplinas.Items[lista_disciplinas.SelectedIndex] && p.M == modulos_combobox.SelectedItem.ToString());
            var source = new BindingSource(bindingList, null);
            notas_gridview.DataSource = bindingList.Select(o => new
            { Nome = o.Nome, Nota = o.Nota }).ToList();
        }

        public void updateCLD()
        {
            lista_disciplinas.Items.Clear();
            Dados.List_disciplinas.ForEach(p => lista_disciplinas.Items.Add(p.Nome));
        }

        public void updateCLM()
        {
            if(lista_disciplinas.SelectedIndex > -1)
            {
                modulos_combobox.Items.Clear();
                for(int i = 1; i != Dados.List_disciplinas.FirstOrDefault(p => p.Nome == lista_disciplinas.Items[lista_disciplinas.SelectedIndex]).Modulos+1; i++)
                {
                    modulos_combobox.Items.Add($"M{i}");
                }
            }
        }

        public Docente()
        {
            InitializeComponent();
            updateCLD();
            updateCLM();
        }

        private Main _mainMenu = new Main();

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Close();
        }

        private void disciplina_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAlunos();
        }

        private void lista_disciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            modulos_combobox.Visible = true;
            updateCLM();
        }

        private void btn_atualizar_notas_Click(object sender, EventArgs e)
        {
            var aluno_xxl = Dados.List_Modulos.FirstOrDefault(p => p.Disciplina == lista_disciplinas.Items[lista_disciplinas.SelectedIndex] && p.M == modulos_combobox.SelectedItem.ToString() && p.Nome == selected_name);
            aluno_xxl.Nota = Convert.ToInt32(txt_nova_nota.Text);
            selected_name = "";
            updateAlunos();
            MessageBox.Show($"O aluno {selected_name} teve as suas notas atualizadas com sucesso!");
        }

        private void notas_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_name = notas_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            monoFlat_Label3.Visible = true;
            txt_nova_nota.Visible = true;
            btn_atualizar_notas.Visible = true;
            MessageBox.Show($"O aluno {selected_name} foi selecionado!");
        }
    }
}
