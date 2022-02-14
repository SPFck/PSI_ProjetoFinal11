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
    public partial class Aluno : Form
    {
        private Main _mainMenu = new Main();
        public void updateAlunos()
        {
            var bindingList = new BindingList<Modulo>(Dados.List_Modulos).Where(p => p.Nome == lista_nomes.Items[lista_nomes.SelectedIndex].ToString() && p.Disciplina == disciplina_combobox.SelectedItem.ToString());
            var source = new BindingSource(bindingList, null);
            alunos_gridview.DataSource = source;
        }

        public void updateCLD()
        {
            disciplina_combobox.Items.Clear();
            Dados.List_disciplinas.ForEach(p => disciplina_combobox.Items.Add(p.Nome));
        }

        public void atualizarLista()
        {
            Dados.List_Alunos.ToList().ForEach(p => lista_nomes.Items.Add(p.Nome));
        }

        public Aluno()
        {
            InitializeComponent();
            atualizarLista();
            updateCLD();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            this.Close();
        }

        private void lista_nomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            disciplina_combobox.Visible = true;
        }

        private void disciplina_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAlunos();
        }

        private void alunos_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
