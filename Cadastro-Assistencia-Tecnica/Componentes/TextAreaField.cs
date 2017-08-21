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
    public partial class TextAreaField : UserControl    {

        

        public TextAreaField()
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
        public event EventHandler TextChangedd
        {
            add { Txt.TextChanged += value; }
            remove { Txt.TextChanged -= value; }
        }


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public  int MaxLength
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


    }
}
