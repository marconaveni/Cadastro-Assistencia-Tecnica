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
    public partial class ComboTextField : UserControl    {

        

        public ComboTextField()
        {
            InitializeComponent();
        }

        private int aceleration;

        private void TextField_Load(object sender, EventArgs e)
        {
            lblTxt.Text = Txt.Text;
            Ani.Left = this.Width / 2;
            Ani.Width = 0;
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler SelectedIndexChanged
        {
            add { Txt.SelectedIndexChanged  += value; }
            remove { Txt.SelectedIndexChanged -= value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler DropDownClosed
        {
            add { Txt.DropDownClosed += value; }
            remove { Txt.DropDownClosed -= value; }
        }

        public string Items
        {
            set { Txt.Items.Add(value); }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
        }

        public int SelectedIndex
        {
            get { return Txt.SelectedIndex; }
            set { Txt.SelectedIndex = value; }
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
                Ani.Width += aceleration + (Txt.Width /100)-1 ;
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

        private void DWAprovado_Click(object sender, EventArgs e)
        {
            Txt.Focus();
            Txt.DroppedDown = true;
        }

        private void Txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTxt.Text = Txt.Text;
        }
    }
}
