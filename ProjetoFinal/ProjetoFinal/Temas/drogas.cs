using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal.Temas
{
    public class TextBox_Heterossexual : TextBox
    {
        public TextBox_Heterossexual()
        {
            this.AutoSize = false;
            this.Location = new Point(8, 10);
            this.Text = String.Empty;
            this.BorderStyle = BorderStyle.None;
            this.TextAlign = HorizontalAlignment.Left;
            this.Font = new Font("Tahoma", 11);
            this.UseSystemPasswordChar = UseSystemPasswordChar;
            this.Multiline = false;
            this.BackColor = Color.FromArgb(66, 76, 85);
            this.ScrollBars = ScrollBars.None;
        }
    }
}
