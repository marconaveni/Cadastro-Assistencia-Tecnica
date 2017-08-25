using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Assistencia_Tecnica.Componentes
{
    public partial class TextFieldValor : UserControl
    {



        public TextFieldValor()
        {
            InitializeComponent();
        }

        private int aceleration;

        private void TextField_Load(object sender, EventArgs e)
        {
            Ani.Left = this.Width / 2;
            Ani.Width = 0;
        }


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public int MaxLength
        {
            get { return Txt.MaxLength; }
            set { Txt.MaxLength = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return Txt.AutoCompleteCustomSource; }
            set { Txt.AutoCompleteCustomSource = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color LineColor
        {
            get { return Ani.BackColor; }
            set { Ani.BackColor = value; }
        }


        private void Txt_Enter(object sender, EventArgs e)
        {
            Ani.Left = this.Width / 2;
            Ani.Width = 0;
            Ani.Height = 2;
            aceleration = 4;
            tm.Enabled = true;
            tm2.Enabled = false;
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            tm2.Enabled = true;
            tm.Enabled = false;

            if (Txt.Text != "" && Txt.Text != ",")
            {
                double valor = Convert.ToDouble(Txt.Text);
                Txt.Text = String.Format("{0:N}", valor);
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            String[] substrings = Txt.Text.Split(',');
            int i = 0;
            int c = 0;
            foreach (var substring in substrings)
            {
                i = Convert.ToInt16(substring.Length);
                c++;
            }

            //&& Txt.SelectionLength == Txt.Text.Length

            if ((i > 1) && (c > 1) && (!char.IsControl(e.KeyChar)) && Txt.SelectedText != Txt.Text)
            {
                e.Handled = true;
            }
            else
            {

                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
                {
                    int numVirgulas = Txt.Text.Split(',').Length;
                    if (e.KeyChar != ',' || numVirgulas > 1 || (e.KeyChar == ',' && Txt.Text == ""))
                    {
                        e.Handled = true;
                    }

                }

            }



        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            if (Ani.Width <= Txt.Width + 2)
            {
                Ani.Width += aceleration + (Txt.Width / 100);
                Ani.Left -= (aceleration / 2) + ((Txt.Width / 100) / 2);
                aceleration = aceleration + 1 * 2;
            }

        }

        private void Tm2_Tick(object sender, EventArgs e)
        {
            if (Ani.Width > 0)
            {
                Ani.Width -= aceleration + (Txt.Width / 100);
                Ani.Left += (aceleration / 2) + ((Txt.Width / 100) / 2);
                aceleration = aceleration - 1 * 2;
            }

        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Txt_Click(object sender, EventArgs e)
        {
            
            if (Txt.Text != "" && Txt.Text != ",")
            {
                double valor = Convert.ToDouble(Txt.Text);
                Txt.Text = String.Format("{0:N}", valor);
            }

            Txt.SelectAll();
        }
    }
}
