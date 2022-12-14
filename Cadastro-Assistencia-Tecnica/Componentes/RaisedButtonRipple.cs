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
    public partial class RaisedButtonRipple : UserControl    {

        

        public RaisedButtonRipple()
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


        private void RaisedButtonRipple_Enter(object sender, EventArgs e)
        {
            ShadowBottom.Height = ShadowBottom.Height + 15;
            ShadowBottom.Width = ShadowBottom.Width + 1;

            ShadowRight.Width = ShadowRight.Width + 10;
            ShadowRight.Height = ShadowRight.Height + 1;
        }

        private void RaisedButtonRipple_Leave(object sender, EventArgs e)
        {
            ShadowBottom.Height = ShadowBottom.Height - 15;
            ShadowBottom.Width = ShadowBottom.Width - 1;

            ShadowRight.Width = ShadowRight.Width - 10;
            ShadowRight.Height = ShadowRight.Height - 1;
        }
    }
}
