
using System;
using System.Windows.Forms;

namespace ProjetoFinal
{
    partial class Secretaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secretaria));
            this.theme = new MonoFlat.MonoFlat_ThemeContainer();
            this.btn_fechar = new MonoFlat.MonoFlat_Button();
            this.paginas = new System.Windows.Forms.TabControl();
            this.Alunos_page = new System.Windows.Forms.TabPage();
            this.alunos_gridview = new System.Windows.Forms.DataGridView();
            this.aluno_remover = new MonoFlat.MonoFlat_Button();
            this.add_aluno = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.txt_idade_aluno = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.txt_email_aluno = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.txt_usr_aluno = new MonoFlat.MonoFlat_TextBox();
            this.professores_tab = new System.Windows.Forms.TabPage();
            this.gridview_professores = new System.Windows.Forms.DataGridView();
            this.txt_disciplina_professor = new System.Windows.Forms.ComboBox();
            this.remover_professor = new MonoFlat.MonoFlat_Button();
            this.adicionar_professor = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label5 = new MonoFlat.MonoFlat_Label();
            this.txt_email_professor = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label6 = new MonoFlat.MonoFlat_Label();
            this.txt_nome_professor = new MonoFlat.MonoFlat_TextBox();
            this.inscricoes_tab = new System.Windows.Forms.TabPage();
            this.alunos2_gridview = new System.Windows.Forms.DataGridView();
            this.btn_desin = new MonoFlat.MonoFlat_Button();
            this.btn_in = new MonoFlat.MonoFlat_Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridview_disciplinas = new System.Windows.Forms.DataGridView();
            this.btn_remover_disciplina = new MonoFlat.MonoFlat_Button();
            this.btn_add_disciplina = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label8 = new MonoFlat.MonoFlat_Label();
            this.txt_n_modulos_disciplina = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label9 = new MonoFlat.MonoFlat_Label();
            this.txt_nome_disciplina = new MonoFlat.MonoFlat_TextBox();
            this.theme.SuspendLayout();
            this.paginas.SuspendLayout();
            this.Alunos_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunos_gridview)).BeginInit();
            this.professores_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_professores)).BeginInit();
            this.inscricoes_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunos2_gridview)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_disciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.theme.Controls.Add(this.btn_fechar);
            this.theme.Controls.Add(this.paginas);
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theme.Name = "theme";
            this.theme.Padding = new System.Windows.Forms.Padding(11, 93, 11, 12);
            this.theme.RoundCorners = true;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(670, 600);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Secretaria";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.Image = null;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar.Location = new System.Drawing.Point(611, 16);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(46, 55);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "X";
            this.btn_fechar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // paginas
            // 
            this.paginas.Controls.Add(this.Alunos_page);
            this.paginas.Controls.Add(this.professores_tab);
            this.paginas.Controls.Add(this.inscricoes_tab);
            this.paginas.Controls.Add(this.tabPage1);
            this.paginas.Location = new System.Drawing.Point(14, 97);
            this.paginas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paginas.Name = "paginas";
            this.paginas.SelectedIndex = 0;
            this.paginas.Size = new System.Drawing.Size(643, 487);
            this.paginas.TabIndex = 0;
            // 
            // Alunos_page
            // 
            this.Alunos_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Alunos_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alunos_page.Controls.Add(this.alunos_gridview);
            this.Alunos_page.Controls.Add(this.aluno_remover);
            this.Alunos_page.Controls.Add(this.add_aluno);
            this.Alunos_page.Controls.Add(this.monoFlat_Label3);
            this.Alunos_page.Controls.Add(this.txt_idade_aluno);
            this.Alunos_page.Controls.Add(this.monoFlat_Label2);
            this.Alunos_page.Controls.Add(this.txt_email_aluno);
            this.Alunos_page.Controls.Add(this.monoFlat_Label1);
            this.Alunos_page.Controls.Add(this.txt_usr_aluno);
            this.Alunos_page.Location = new System.Drawing.Point(4, 29);
            this.Alunos_page.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Alunos_page.Name = "Alunos_page";
            this.Alunos_page.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Alunos_page.Size = new System.Drawing.Size(635, 454);
            this.Alunos_page.TabIndex = 0;
            this.Alunos_page.Text = "Alunos";
            // 
            // alunos_gridview
            // 
            this.alunos_gridview.AllowUserToAddRows = false;
            this.alunos_gridview.AllowUserToDeleteRows = false;
            this.alunos_gridview.AllowUserToOrderColumns = true;
            this.alunos_gridview.AllowUserToResizeColumns = false;
            this.alunos_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunos_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alunos_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alunos_gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.alunos_gridview.Location = new System.Drawing.Point(267, 8);
            this.alunos_gridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alunos_gridview.Name = "alunos_gridview";
            this.alunos_gridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunos_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.alunos_gridview.RowHeadersWidth = 51;
            this.alunos_gridview.RowTemplate.Height = 25;
            this.alunos_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alunos_gridview.Size = new System.Drawing.Size(360, 436);
            this.alunos_gridview.TabIndex = 11;
            this.alunos_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alunos_gridview_CellContentClick);
            // 
            // aluno_remover
            // 
            this.aluno_remover.BackColor = System.Drawing.Color.Transparent;
            this.aluno_remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aluno_remover.Image = null;
            this.aluno_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aluno_remover.Location = new System.Drawing.Point(7, 367);
            this.aluno_remover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aluno_remover.Name = "aluno_remover";
            this.aluno_remover.Size = new System.Drawing.Size(251, 55);
            this.aluno_remover.TabIndex = 10;
            this.aluno_remover.Text = "Remover Aluno";
            this.aluno_remover.TextAlignment = System.Drawing.StringAlignment.Center;
            this.aluno_remover.Click += new System.EventHandler(this.aluno_remover_Click);
            // 
            // add_aluno
            // 
            this.add_aluno.BackColor = System.Drawing.Color.Transparent;
            this.add_aluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_aluno.Image = null;
            this.add_aluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_aluno.Location = new System.Drawing.Point(7, 289);
            this.add_aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_aluno.Name = "add_aluno";
            this.add_aluno.Size = new System.Drawing.Size(251, 55);
            this.add_aluno.TabIndex = 9;
            this.add_aluno.Text = "Adicionar Aluno";
            this.add_aluno.TextAlignment = System.Drawing.StringAlignment.Center;
            this.add_aluno.Click += new System.EventHandler(this.add_aluno_Click);
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label3.Location = new System.Drawing.Point(5, 185);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(63, 28);
            this.monoFlat_Label3.TabIndex = 8;
            this.monoFlat_Label3.Text = "Idade";
            // 
            // txt_idade_aluno
            // 
            this.txt_idade_aluno.BackColor = System.Drawing.Color.Transparent;
            this.txt_idade_aluno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_idade_aluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_idade_aluno.Image = null;
            this.txt_idade_aluno.Location = new System.Drawing.Point(5, 217);
            this.txt_idade_aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idade_aluno.MaxLength = 32767;
            this.txt_idade_aluno.Multiline = false;
            this.txt_idade_aluno.Name = "txt_idade_aluno";
            this.txt_idade_aluno.ReadOnly = false;
            this.txt_idade_aluno.Size = new System.Drawing.Size(256, 46);
            this.txt_idade_aluno.TabIndex = 7;
            this.txt_idade_aluno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_idade_aluno.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(7, 95);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(60, 28);
            this.monoFlat_Label2.TabIndex = 6;
            this.monoFlat_Label2.Text = "Email";
            // 
            // txt_email_aluno
            // 
            this.txt_email_aluno.BackColor = System.Drawing.Color.Transparent;
            this.txt_email_aluno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email_aluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_email_aluno.Image = null;
            this.txt_email_aluno.Location = new System.Drawing.Point(5, 127);
            this.txt_email_aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email_aluno.MaxLength = 32767;
            this.txt_email_aluno.Multiline = false;
            this.txt_email_aluno.Name = "txt_email_aluno";
            this.txt_email_aluno.ReadOnly = false;
            this.txt_email_aluno.Size = new System.Drawing.Size(256, 46);
            this.txt_email_aluno.TabIndex = 5;
            this.txt_email_aluno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email_aluno.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(7, 4);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(68, 28);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Nome";
            // 
            // txt_usr_aluno
            // 
            this.txt_usr_aluno.BackColor = System.Drawing.Color.Transparent;
            this.txt_usr_aluno.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usr_aluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_usr_aluno.Image = null;
            this.txt_usr_aluno.Location = new System.Drawing.Point(5, 36);
            this.txt_usr_aluno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_usr_aluno.MaxLength = 32767;
            this.txt_usr_aluno.Multiline = false;
            this.txt_usr_aluno.Name = "txt_usr_aluno";
            this.txt_usr_aluno.ReadOnly = false;
            this.txt_usr_aluno.Size = new System.Drawing.Size(256, 46);
            this.txt_usr_aluno.TabIndex = 3;
            this.txt_usr_aluno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usr_aluno.UseSystemPasswordChar = false;
            // 
            // professores_tab
            // 
            this.professores_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.professores_tab.Controls.Add(this.gridview_professores);
            this.professores_tab.Controls.Add(this.txt_disciplina_professor);
            this.professores_tab.Controls.Add(this.remover_professor);
            this.professores_tab.Controls.Add(this.adicionar_professor);
            this.professores_tab.Controls.Add(this.monoFlat_Label4);
            this.professores_tab.Controls.Add(this.monoFlat_Label5);
            this.professores_tab.Controls.Add(this.txt_email_professor);
            this.professores_tab.Controls.Add(this.monoFlat_Label6);
            this.professores_tab.Controls.Add(this.txt_nome_professor);
            this.professores_tab.Location = new System.Drawing.Point(4, 29);
            this.professores_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professores_tab.Name = "professores_tab";
            this.professores_tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professores_tab.Size = new System.Drawing.Size(635, 454);
            this.professores_tab.TabIndex = 1;
            this.professores_tab.Text = "Professores";
            // 
            // gridview_professores
            // 
            this.gridview_professores.AllowUserToAddRows = false;
            this.gridview_professores.AllowUserToDeleteRows = false;
            this.gridview_professores.AllowUserToOrderColumns = true;
            this.gridview_professores.AllowUserToResizeColumns = false;
            this.gridview_professores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridview_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_professores.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridview_professores.Location = new System.Drawing.Point(271, 8);
            this.gridview_professores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridview_professores.Name = "gridview_professores";
            this.gridview_professores.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_professores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridview_professores.RowHeadersWidth = 51;
            this.gridview_professores.RowTemplate.Height = 25;
            this.gridview_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_professores.Size = new System.Drawing.Size(360, 436);
            this.gridview_professores.TabIndex = 21;
            this.gridview_professores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_professores_CellContentClick);
            // 
            // txt_disciplina_professor
            // 
            this.txt_disciplina_professor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_disciplina_professor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_disciplina_professor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_disciplina_professor.ForeColor = System.Drawing.Color.White;
            this.txt_disciplina_professor.FormattingEnabled = true;
            this.txt_disciplina_professor.Location = new System.Drawing.Point(10, 220);
            this.txt_disciplina_professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_disciplina_professor.Name = "txt_disciplina_professor";
            this.txt_disciplina_professor.Size = new System.Drawing.Size(238, 32);
            this.txt_disciplina_professor.TabIndex = 20;
            // 
            // remover_professor
            // 
            this.remover_professor.BackColor = System.Drawing.Color.Transparent;
            this.remover_professor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remover_professor.Image = null;
            this.remover_professor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remover_professor.Location = new System.Drawing.Point(10, 369);
            this.remover_professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remover_professor.Name = "remover_professor";
            this.remover_professor.Size = new System.Drawing.Size(251, 55);
            this.remover_professor.TabIndex = 19;
            this.remover_professor.Text = "Remover Professor";
            this.remover_professor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.remover_professor.Click += new System.EventHandler(this.remover_professor_Click);
            // 
            // adicionar_professor
            // 
            this.adicionar_professor.BackColor = System.Drawing.Color.Transparent;
            this.adicionar_professor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adicionar_professor.Image = null;
            this.adicionar_professor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adicionar_professor.Location = new System.Drawing.Point(10, 292);
            this.adicionar_professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adicionar_professor.Name = "adicionar_professor";
            this.adicionar_professor.Size = new System.Drawing.Size(251, 55);
            this.adicionar_professor.TabIndex = 18;
            this.adicionar_professor.Text = "Adicionar Professor";
            this.adicionar_professor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.adicionar_professor.Click += new System.EventHandler(this.adicionar_professor_Click);
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label4.Location = new System.Drawing.Point(10, 188);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(107, 28);
            this.monoFlat_Label4.TabIndex = 16;
            this.monoFlat_Label4.Text = "Disciplinas";
            // 
            // monoFlat_Label5
            // 
            this.monoFlat_Label5.AutoSize = true;
            this.monoFlat_Label5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label5.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label5.Location = new System.Drawing.Point(10, 97);
            this.monoFlat_Label5.Name = "monoFlat_Label5";
            this.monoFlat_Label5.Size = new System.Drawing.Size(60, 28);
            this.monoFlat_Label5.TabIndex = 14;
            this.monoFlat_Label5.Text = "Email";
            // 
            // txt_email_professor
            // 
            this.txt_email_professor.BackColor = System.Drawing.Color.Transparent;
            this.txt_email_professor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email_professor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_email_professor.Image = null;
            this.txt_email_professor.Location = new System.Drawing.Point(8, 129);
            this.txt_email_professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email_professor.MaxLength = 32767;
            this.txt_email_professor.Multiline = false;
            this.txt_email_professor.Name = "txt_email_professor";
            this.txt_email_professor.ReadOnly = false;
            this.txt_email_professor.Size = new System.Drawing.Size(256, 46);
            this.txt_email_professor.TabIndex = 13;
            this.txt_email_professor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email_professor.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label6
            // 
            this.monoFlat_Label6.AutoSize = true;
            this.monoFlat_Label6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label6.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label6.Location = new System.Drawing.Point(10, 7);
            this.monoFlat_Label6.Name = "monoFlat_Label6";
            this.monoFlat_Label6.Size = new System.Drawing.Size(68, 28);
            this.monoFlat_Label6.TabIndex = 12;
            this.monoFlat_Label6.Text = "Nome";
            // 
            // txt_nome_professor
            // 
            this.txt_nome_professor.BackColor = System.Drawing.Color.Transparent;
            this.txt_nome_professor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_professor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_nome_professor.Image = null;
            this.txt_nome_professor.Location = new System.Drawing.Point(8, 39);
            this.txt_nome_professor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome_professor.MaxLength = 32767;
            this.txt_nome_professor.Multiline = false;
            this.txt_nome_professor.Name = "txt_nome_professor";
            this.txt_nome_professor.ReadOnly = false;
            this.txt_nome_professor.Size = new System.Drawing.Size(256, 46);
            this.txt_nome_professor.TabIndex = 11;
            this.txt_nome_professor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome_professor.UseSystemPasswordChar = false;
            // 
            // inscricoes_tab
            // 
            this.inscricoes_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.inscricoes_tab.Controls.Add(this.alunos2_gridview);
            this.inscricoes_tab.Controls.Add(this.btn_desin);
            this.inscricoes_tab.Controls.Add(this.btn_in);
            this.inscricoes_tab.Location = new System.Drawing.Point(4, 29);
            this.inscricoes_tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inscricoes_tab.Name = "inscricoes_tab";
            this.inscricoes_tab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inscricoes_tab.Size = new System.Drawing.Size(635, 454);
            this.inscricoes_tab.TabIndex = 2;
            this.inscricoes_tab.Text = "Inscrições";
            // 
            // alunos2_gridview
            // 
            this.alunos2_gridview.AllowUserToAddRows = false;
            this.alunos2_gridview.AllowUserToDeleteRows = false;
            this.alunos2_gridview.AllowUserToOrderColumns = true;
            this.alunos2_gridview.AllowUserToResizeColumns = false;
            this.alunos2_gridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunos2_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.alunos2_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alunos2_gridview.DefaultCellStyle = dataGridViewCellStyle8;
            this.alunos2_gridview.Location = new System.Drawing.Point(268, 11);
            this.alunos2_gridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alunos2_gridview.Name = "alunos2_gridview";
            this.alunos2_gridview.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alunos2_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.alunos2_gridview.RowHeadersWidth = 51;
            this.alunos2_gridview.RowTemplate.Height = 25;
            this.alunos2_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alunos2_gridview.Size = new System.Drawing.Size(360, 436);
            this.alunos2_gridview.TabIndex = 20;
            this.alunos2_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alunos2_gridview_CellContentClick);
            // 
            // btn_desin
            // 
            this.btn_desin.BackColor = System.Drawing.Color.Transparent;
            this.btn_desin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_desin.Image = null;
            this.btn_desin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_desin.Location = new System.Drawing.Point(8, 74);
            this.btn_desin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_desin.Name = "btn_desin";
            this.btn_desin.Size = new System.Drawing.Size(251, 55);
            this.btn_desin.TabIndex = 19;
            this.btn_desin.Text = "Desinscrever Aluno";
            this.btn_desin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_desin.Click += new System.EventHandler(this.btn_desin_Click);
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.Color.Transparent;
            this.btn_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_in.Image = null;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(8, 11);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(251, 55);
            this.btn_in.TabIndex = 18;
            this.btn_in.Text = "Inscrever Aluno";
            this.btn_in.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.gridview_disciplinas);
            this.tabPage1.Controls.Add(this.btn_remover_disciplina);
            this.tabPage1.Controls.Add(this.btn_add_disciplina);
            this.tabPage1.Controls.Add(this.monoFlat_Label8);
            this.tabPage1.Controls.Add(this.txt_n_modulos_disciplina);
            this.tabPage1.Controls.Add(this.monoFlat_Label9);
            this.tabPage1.Controls.Add(this.txt_nome_disciplina);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 454);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Disciplinas";
            // 
            // gridview_disciplinas
            // 
            this.gridview_disciplinas.AllowUserToAddRows = false;
            this.gridview_disciplinas.AllowUserToDeleteRows = false;
            this.gridview_disciplinas.AllowUserToOrderColumns = true;
            this.gridview_disciplinas.AllowUserToResizeColumns = false;
            this.gridview_disciplinas.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_disciplinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridview_disciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_disciplinas.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridview_disciplinas.Location = new System.Drawing.Point(268, 11);
            this.gridview_disciplinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridview_disciplinas.Name = "gridview_disciplinas";
            this.gridview_disciplinas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_disciplinas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridview_disciplinas.RowHeadersWidth = 51;
            this.gridview_disciplinas.RowTemplate.Height = 25;
            this.gridview_disciplinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_disciplinas.Size = new System.Drawing.Size(360, 436);
            this.gridview_disciplinas.TabIndex = 20;
            this.gridview_disciplinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_disciplinas_CellContentClick);
            // 
            // btn_remover_disciplina
            // 
            this.btn_remover_disciplina.BackColor = System.Drawing.Color.Transparent;
            this.btn_remover_disciplina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remover_disciplina.Image = null;
            this.btn_remover_disciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover_disciplina.Location = new System.Drawing.Point(8, 370);
            this.btn_remover_disciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remover_disciplina.Name = "btn_remover_disciplina";
            this.btn_remover_disciplina.Size = new System.Drawing.Size(251, 55);
            this.btn_remover_disciplina.TabIndex = 19;
            this.btn_remover_disciplina.Text = "Remover Disciplina";
            this.btn_remover_disciplina.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_remover_disciplina.Click += new System.EventHandler(this.btn_remover_disciplina_Click);
            // 
            // btn_add_disciplina
            // 
            this.btn_add_disciplina.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_disciplina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_disciplina.Image = null;
            this.btn_add_disciplina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_disciplina.Location = new System.Drawing.Point(8, 292);
            this.btn_add_disciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_disciplina.Name = "btn_add_disciplina";
            this.btn_add_disciplina.Size = new System.Drawing.Size(251, 55);
            this.btn_add_disciplina.TabIndex = 18;
            this.btn_add_disciplina.Text = "Adicionar Disciplina";
            this.btn_add_disciplina.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_add_disciplina.Click += new System.EventHandler(this.btn_add_disciplina_Click);
            // 
            // monoFlat_Label8
            // 
            this.monoFlat_Label8.AutoSize = true;
            this.monoFlat_Label8.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label8.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label8.Location = new System.Drawing.Point(8, 98);
            this.monoFlat_Label8.Name = "monoFlat_Label8";
            this.monoFlat_Label8.Size = new System.Drawing.Size(122, 28);
            this.monoFlat_Label8.TabIndex = 15;
            this.monoFlat_Label8.Text = "Nº Módulos";
            // 
            // txt_n_modulos_disciplina
            // 
            this.txt_n_modulos_disciplina.BackColor = System.Drawing.Color.Transparent;
            this.txt_n_modulos_disciplina.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_n_modulos_disciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_n_modulos_disciplina.Image = null;
            this.txt_n_modulos_disciplina.Location = new System.Drawing.Point(6, 130);
            this.txt_n_modulos_disciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_n_modulos_disciplina.MaxLength = 32767;
            this.txt_n_modulos_disciplina.Multiline = false;
            this.txt_n_modulos_disciplina.Name = "txt_n_modulos_disciplina";
            this.txt_n_modulos_disciplina.ReadOnly = false;
            this.txt_n_modulos_disciplina.Size = new System.Drawing.Size(256, 46);
            this.txt_n_modulos_disciplina.TabIndex = 14;
            this.txt_n_modulos_disciplina.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_n_modulos_disciplina.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label9
            // 
            this.monoFlat_Label9.AutoSize = true;
            this.monoFlat_Label9.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label9.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label9.Location = new System.Drawing.Point(8, 7);
            this.monoFlat_Label9.Name = "monoFlat_Label9";
            this.monoFlat_Label9.Size = new System.Drawing.Size(68, 28);
            this.monoFlat_Label9.TabIndex = 13;
            this.monoFlat_Label9.Text = "Nome";
            // 
            // txt_nome_disciplina
            // 
            this.txt_nome_disciplina.BackColor = System.Drawing.Color.Transparent;
            this.txt_nome_disciplina.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_disciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_nome_disciplina.Image = null;
            this.txt_nome_disciplina.Location = new System.Drawing.Point(6, 39);
            this.txt_nome_disciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome_disciplina.MaxLength = 32767;
            this.txt_nome_disciplina.Multiline = false;
            this.txt_nome_disciplina.Name = "txt_nome_disciplina";
            this.txt_nome_disciplina.ReadOnly = false;
            this.txt_nome_disciplina.Size = new System.Drawing.Size(256, 46);
            this.txt_nome_disciplina.TabIndex = 12;
            this.txt_nome_disciplina.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome_disciplina.UseSystemPasswordChar = false;
            // 
            // Secretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 600);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Secretaria";
            this.Text = "Secretaria";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.theme.ResumeLayout(false);
            this.paginas.ResumeLayout(false);
            this.Alunos_page.ResumeLayout(false);
            this.Alunos_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunos_gridview)).EndInit();
            this.professores_tab.ResumeLayout(false);
            this.professores_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_professores)).EndInit();
            this.inscricoes_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alunos2_gridview)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_disciplinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer theme;
        private System.Windows.Forms.TabControl paginas;
        private System.Windows.Forms.TabPage Alunos_page;
        private System.Windows.Forms.TabPage professores_tab;
        private System.Windows.Forms.TabPage inscricoes_tab;
        private MonoFlat.MonoFlat_Button add_aluno;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_TextBox txt_idade_aluno;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_TextBox txt_email_aluno;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_TextBox txt_usr_aluno;
        private MonoFlat.MonoFlat_Button aluno_remover;
        private MonoFlat.MonoFlat_Button remover_professor;
        private MonoFlat.MonoFlat_Button adicionar_professor;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private MonoFlat.MonoFlat_Label monoFlat_Label5;
        private MonoFlat.MonoFlat_TextBox txt_email_professor;
        private MonoFlat.MonoFlat_Label monoFlat_Label6;
        private MonoFlat.MonoFlat_TextBox txt_nome_professor;
        private System.Windows.Forms.ComboBox txt_disciplina_professor;
        private System.Windows.Forms.DataGridView alunos_gridview;
        private MonoFlat.MonoFlat_Button btn_fechar;
        private DataGridView gridview_professores;
        private DataGridView alunos2_gridview;
        private MonoFlat.MonoFlat_Button btn_desin;
        private MonoFlat.MonoFlat_Button btn_in;
        private TabPage tabPage1;
        private DataGridView gridview_disciplinas;
        private MonoFlat.MonoFlat_Button btn_remover_disciplina;
        private MonoFlat.MonoFlat_Button btn_add_disciplina;
        private MonoFlat.MonoFlat_Label monoFlat_Label8;
        private MonoFlat.MonoFlat_TextBox txt_n_modulos_disciplina;
        private MonoFlat.MonoFlat_Label monoFlat_Label9;
        private MonoFlat.MonoFlat_TextBox txt_nome_disciplina;
    }
}