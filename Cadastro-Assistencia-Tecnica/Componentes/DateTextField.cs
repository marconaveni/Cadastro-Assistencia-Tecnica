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
    public partial class DateTextField : UserControl    {

        

        public DateTextField()
        {
            InitializeComponent();
        }

        private int aceleration;

        private void TextField_Load(object sender, EventArgs e)
        {
            Ani.Left = this.Width / 2;
            Ani.Width = 0;
        }



        public override string Text
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
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

        private void tm_Tick(object sender, EventArgs e)
        {
            if (Ani.Width <= Txt.Width)
            {
                Ani.Width += aceleration + (Txt.Width / 100) - 1;
                Ani.Left -= (aceleration / 2) + ((Txt.Width / 100) / 2);
                aceleration++;
            }

        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            if (Ani.Width > 0)
            {
                Ani.Width -= aceleration + (Txt.Width / 100) - 1;
                Ani.Left += (aceleration / 2) + ((Txt.Width / 100) / 2);
                aceleration--;
            }

        }

        private void TDEntrada_Click(object sender, EventArgs e)
        {
            Txt.Select();
            SendKeys.Send("%{DOWN}");
        }
    }
}
