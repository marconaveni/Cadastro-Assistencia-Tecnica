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
    public partial class ColoredButton : UserControl
    {



        public ColoredButton()
        {
            InitializeComponent();
        }


        private void TextField_Load(object sender, EventArgs e)
        {

        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler EnteredFocus
        {
            add { Btn.Enter += value; }
            remove { Btn.Enter -= value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler Clicked
        {
            add { Btn.Click += value; }
            remove { Btn.Click -= value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get { return Btn.Text; }
            set { Btn.Text = value; }
        }

        private int contador;
        private void RaisedButtonRipple_Enter(object sender, EventArgs e)
        {
            //ShadowBottom.Height = ShadowBottom.Height + 40;
            TM1.Enabled = true;
            TM2.Enabled = false;

        }

        private void RaisedButtonRipple_Leave(object sender, EventArgs e)
        {
            //ShadowBottom.Height = ShadowBottom.Height - 40;
            TM1.Enabled = false;
            TM2.Enabled = true;
        }

        private void TM1_Tick(object sender, EventArgs e)
        {
            if (contador < 15)
            {
                ShadowBottom.Height = ShadowBottom.Height + 1 * 2;
                contador++;
            }

        }

        private void TM2_Tick(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                ShadowBottom.Height = ShadowBottom.Height - 1 * 2;
                contador--;
            }
        }
    }
}
