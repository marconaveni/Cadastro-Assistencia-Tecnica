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







    }
}
