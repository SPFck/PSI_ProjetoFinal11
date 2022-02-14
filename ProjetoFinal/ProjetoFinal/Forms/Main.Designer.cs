
namespace ProjetoFinal
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.main_theme = new MonoFlat.MonoFlat_ThemeContainer();
            this.txt_passwd = new ProjetoFinal.Temas.TextBox_Heterossexual();
            this.txt_usr = new ProjetoFinal.Temas.TextBox_Heterossexual();
            this.btn_fechar = new MonoFlat.MonoFlat_Button();
            this.toggle_mostrar_senha = new MonoFlat.MonoFlat_Toggle();
            this.txt_entrar = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.main_theme.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_theme
            // 
            this.main_theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.main_theme.Controls.Add(this.txt_passwd);
            this.main_theme.Controls.Add(this.txt_usr);
            this.main_theme.Controls.Add(this.btn_fechar);
            this.main_theme.Controls.Add(this.toggle_mostrar_senha);
            this.main_theme.Controls.Add(this.txt_entrar);
            this.main_theme.Controls.Add(this.monoFlat_Label2);
            this.main_theme.Controls.Add(this.monoFlat_Label1);
            this.main_theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_theme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_theme.Location = new System.Drawing.Point(0, 0);
            this.main_theme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main_theme.Name = "main_theme";
            this.main_theme.Padding = new System.Windows.Forms.Padding(11, 93, 11, 12);
            this.main_theme.RoundCorners = true;
            this.main_theme.Sizable = false;
            this.main_theme.Size = new System.Drawing.Size(288, 400);
            this.main_theme.SmartBounds = true;
            this.main_theme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.main_theme.TabIndex = 0;
            this.main_theme.Text = "Login";
            // 
            // txt_passwd
            // 
            this.txt_passwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.txt_passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_passwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_passwd.Location = new System.Drawing.Point(16, 236);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PlaceholderText = "Senha";
            this.txt_passwd.Size = new System.Drawing.Size(256, 47);
            this.txt_passwd.TabIndex = 8;
            this.txt_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_passwd.UseSystemPasswordChar = true;
            this.txt_passwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_passwd_KeyDown);
            // 
            // txt_usr
            // 
            this.txt_usr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.txt_usr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usr.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_usr.Location = new System.Drawing.Point(16, 120);
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.PlaceholderText = "Nome";
            this.txt_usr.Size = new System.Drawing.Size(256, 47);
            this.txt_usr.TabIndex = 7;
            this.txt_usr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_usr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usr_KeyDown);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.Image = null;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar.Location = new System.Drawing.Point(229, 16);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(46, 55);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "X";
            this.btn_fechar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // toggle_mostrar_senha
            // 
            this.toggle_mostrar_senha.Location = new System.Drawing.Point(16, 320);
            this.toggle_mostrar_senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggle_mostrar_senha.Name = "toggle_mostrar_senha";
            this.toggle_mostrar_senha.Size = new System.Drawing.Size(76, 33);
            this.toggle_mostrar_senha.TabIndex = 5;
            this.toggle_mostrar_senha.Toggled = false;
            this.toggle_mostrar_senha.Type = MonoFlat.MonoFlat_Toggle._Type.CheckMark;
            this.toggle_mostrar_senha.ToggledChanged += new MonoFlat.MonoFlat_Toggle.ToggledChangedEventHandler(this.toggle_mostrar_senha_ToggledChanged);
            // 
            // txt_entrar
            // 
            this.txt_entrar.BackColor = System.Drawing.Color.Transparent;
            this.txt_entrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_entrar.Image = null;
            this.txt_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_entrar.Location = new System.Drawing.Point(110, 316);
            this.txt_entrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_entrar.Name = "txt_entrar";
            this.txt_entrar.Size = new System.Drawing.Size(160, 55);
            this.txt_entrar.TabIndex = 4;
            this.txt_entrar.Text = "Entrar";
            this.txt_entrar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txt_entrar.Click += new System.EventHandler(this.txt_entrar_Click);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(16, 205);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(68, 28);
            this.monoFlat_Label2.TabIndex = 3;
            this.monoFlat_Label2.Text = "Senha";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(16, 89);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(68, 28);
            this.monoFlat_Label1.TabIndex = 2;
            this.monoFlat_Label1.Text = "Nome";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 400);
            this.Controls.Add(this.main_theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.main_theme.ResumeLayout(false);
            this.main_theme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer main_theme;
        private MonoFlat.MonoFlat_Toggle toggle_mostrar_senha;
        private MonoFlat.MonoFlat_Button txt_entrar;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button btn_fechar;
        private Temas.TextBox_Heterossexual txt_usr;
        private Temas.TextBox_Heterossexual txt_passwd;
    }
}

