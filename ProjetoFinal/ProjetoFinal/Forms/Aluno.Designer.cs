
namespace ProjetoFinal
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.theme = new MonoFlat.MonoFlat_ThemeContainer();
            this.alunos_gridview = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new MonoFlat.MonoFlat_Button();
            this.disciplina_combobox = new System.Windows.Forms.ComboBox();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.lista_nomes = new System.Windows.Forms.ListBox();
            this.theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunos_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.theme.Controls.Add(this.alunos_gridview);
            this.theme.Controls.Add(this.btn_fechar);
            this.theme.Controls.Add(this.disciplina_combobox);
            this.theme.Controls.Add(this.monoFlat_Label2);
            this.theme.Controls.Add(this.monoFlat_Label1);
            this.theme.Controls.Add(this.lista_nomes);
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theme.Name = "theme";
            this.theme.Padding = new System.Windows.Forms.Padding(11, 93, 11, 12);
            this.theme.RoundCorners = true;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(1021, 600);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Aluno";
            // 
            // alunos_gridview
            // 
            this.alunos_gridview.AllowUserToAddRows = false;
            this.alunos_gridview.AllowUserToDeleteRows = false;
            this.alunos_gridview.AllowUserToOrderColumns = true;
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
            this.alunos_gridview.Location = new System.Drawing.Point(315, 151);
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
            this.alunos_gridview.Size = new System.Drawing.Size(692, 436);
            this.alunos_gridview.TabIndex = 12;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.Image = null;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar.Location = new System.Drawing.Point(961, 13);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(46, 55);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "X";
            this.btn_fechar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // disciplina_combobox
            // 
            this.disciplina_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.disciplina_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplina_combobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disciplina_combobox.ForeColor = System.Drawing.Color.White;
            this.disciplina_combobox.FormattingEnabled = true;
            this.disciplina_combobox.Items.AddRange(new object[] {
            ""});
            this.disciplina_combobox.Location = new System.Drawing.Point(519, 97);
            this.disciplina_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disciplina_combobox.Name = "disciplina_combobox";
            this.disciplina_combobox.Size = new System.Drawing.Size(238, 32);
            this.disciplina_combobox.TabIndex = 5;
            this.disciplina_combobox.Visible = false;
            this.disciplina_combobox.SelectedIndexChanged += new System.EventHandler(this.disciplina_combobox_SelectedIndexChanged);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(417, 99);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(103, 28);
            this.monoFlat_Label2.TabIndex = 4;
            this.monoFlat_Label2.Text = "Disciplina:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(15, 93);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(82, 28);
            this.monoFlat_Label1.TabIndex = 3;
            this.monoFlat_Label1.Text = "Nomes:";
            // 
            // lista_nomes
            // 
            this.lista_nomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lista_nomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista_nomes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lista_nomes.ForeColor = System.Drawing.Color.White;
            this.lista_nomes.FormattingEnabled = true;
            this.lista_nomes.ItemHeight = 24;
            this.lista_nomes.Location = new System.Drawing.Point(14, 125);
            this.lista_nomes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lista_nomes.Name = "lista_nomes";
            this.lista_nomes.Size = new System.Drawing.Size(295, 458);
            this.lista_nomes.TabIndex = 0;
            this.lista_nomes.SelectedIndexChanged += new System.EventHandler(this.lista_nomes_SelectedIndexChanged);
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 600);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunos_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer theme;
        private System.Windows.Forms.ListBox lista_nomes;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.ComboBox disciplina_combobox;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Button btn_fechar;
        private System.Windows.Forms.DataGridView alunos_gridview;
    }
}