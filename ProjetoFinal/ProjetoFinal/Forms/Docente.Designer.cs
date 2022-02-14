
namespace ProjetoFinal
{
    partial class Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docente));
            this.theme = new MonoFlat.MonoFlat_ThemeContainer();
            this.btn_atualizar_notas = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.txt_nova_nota = new MonoFlat.MonoFlat_TextBox();
            this.notas_gridview = new System.Windows.Forms.DataGridView();
            this.btn_fechar = new MonoFlat.MonoFlat_Button();
            this.modulos_combobox = new System.Windows.Forms.ComboBox();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.lista_disciplinas = new System.Windows.Forms.ListBox();
            this.theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notas_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.theme.Controls.Add(this.btn_atualizar_notas);
            this.theme.Controls.Add(this.monoFlat_Label3);
            this.theme.Controls.Add(this.txt_nova_nota);
            this.theme.Controls.Add(this.notas_gridview);
            this.theme.Controls.Add(this.btn_fechar);
            this.theme.Controls.Add(this.modulos_combobox);
            this.theme.Controls.Add(this.monoFlat_Label2);
            this.theme.Controls.Add(this.monoFlat_Label1);
            this.theme.Controls.Add(this.lista_disciplinas);
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theme.Name = "theme";
            this.theme.Padding = new System.Windows.Forms.Padding(11, 93, 11, 12);
            this.theme.RoundCorners = true;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(933, 600);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.theme.TabIndex = 0;
            this.theme.Text = "Docente";
            // 
            // btn_atualizar_notas
            // 
            this.btn_atualizar_notas.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar_notas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_atualizar_notas.Image = null;
            this.btn_atualizar_notas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atualizar_notas.Location = new System.Drawing.Point(726, 343);
            this.btn_atualizar_notas.Name = "btn_atualizar_notas";
            this.btn_atualizar_notas.Size = new System.Drawing.Size(193, 51);
            this.btn_atualizar_notas.TabIndex = 17;
            this.btn_atualizar_notas.Text = "Atualizar";
            this.btn_atualizar_notas.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_atualizar_notas.Visible = false;
            this.btn_atualizar_notas.Click += new System.EventHandler(this.btn_atualizar_notas_Click);
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label3.Location = new System.Drawing.Point(726, 260);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(61, 28);
            this.monoFlat_Label3.TabIndex = 16;
            this.monoFlat_Label3.Text = "Nota:";
            this.monoFlat_Label3.Visible = false;
            // 
            // txt_nova_nota
            // 
            this.txt_nova_nota.BackColor = System.Drawing.Color.Transparent;
            this.txt_nova_nota.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nova_nota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_nova_nota.Image = null;
            this.txt_nova_nota.Location = new System.Drawing.Point(726, 291);
            this.txt_nova_nota.MaxLength = 32767;
            this.txt_nova_nota.Multiline = false;
            this.txt_nova_nota.Name = "txt_nova_nota";
            this.txt_nova_nota.ReadOnly = false;
            this.txt_nova_nota.Size = new System.Drawing.Size(195, 46);
            this.txt_nova_nota.TabIndex = 15;
            this.txt_nova_nota.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nova_nota.UseSystemPasswordChar = false;
            this.txt_nova_nota.Visible = false;
            // 
            // notas_gridview
            // 
            this.notas_gridview.AllowUserToAddRows = false;
            this.notas_gridview.AllowUserToDeleteRows = false;
            this.notas_gridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notas_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.notas_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notas_gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.notas_gridview.Location = new System.Drawing.Point(241, 131);
            this.notas_gridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notas_gridview.Name = "notas_gridview";
            this.notas_gridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notas_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.notas_gridview.RowHeadersWidth = 51;
            this.notas_gridview.RowTemplate.Height = 25;
            this.notas_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notas_gridview.Size = new System.Drawing.Size(479, 456);
            this.notas_gridview.TabIndex = 14;
            this.notas_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notas_gridview_CellContentClick);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.Image = null;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar.Location = new System.Drawing.Point(873, 13);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(46, 55);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.Text = "X";
            this.btn_fechar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // modulos_combobox
            // 
            this.modulos_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.modulos_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulos_combobox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modulos_combobox.ForeColor = System.Drawing.Color.White;
            this.modulos_combobox.FormattingEnabled = true;
            this.modulos_combobox.Location = new System.Drawing.Point(359, 91);
            this.modulos_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modulos_combobox.Name = "modulos_combobox";
            this.modulos_combobox.Size = new System.Drawing.Size(238, 32);
            this.modulos_combobox.TabIndex = 11;
            this.modulos_combobox.Visible = false;
            this.modulos_combobox.SelectedIndexChanged += new System.EventHandler(this.disciplina_combobox_SelectedIndexChanged);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(257, 93);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(97, 28);
            this.monoFlat_Label2.TabIndex = 10;
            this.monoFlat_Label2.Text = "Modulos:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(13, 93);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(107, 28);
            this.monoFlat_Label1.TabIndex = 9;
            this.monoFlat_Label1.Text = "Disciplinas";
            // 
            // lista_disciplinas
            // 
            this.lista_disciplinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lista_disciplinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista_disciplinas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lista_disciplinas.ForeColor = System.Drawing.Color.White;
            this.lista_disciplinas.FormattingEnabled = true;
            this.lista_disciplinas.ItemHeight = 24;
            this.lista_disciplinas.Location = new System.Drawing.Point(11, 125);
            this.lista_disciplinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lista_disciplinas.Name = "lista_disciplinas";
            this.lista_disciplinas.Size = new System.Drawing.Size(224, 458);
            this.lista_disciplinas.TabIndex = 8;
            this.lista_disciplinas.SelectedIndexChanged += new System.EventHandler(this.lista_disciplinas_SelectedIndexChanged);
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Docente";
            this.Text = "Docente";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notas_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer theme;
        private MonoFlat.MonoFlat_Button btn_fechar;
        private System.Windows.Forms.ComboBox modulos_combobox;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.ListBox lista_disciplinas;
        private System.Windows.Forms.DataGridView notas_gridview;
        private MonoFlat.MonoFlat_Button btn_atualizar_notas;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_TextBox txt_nova_nota;
    }
}