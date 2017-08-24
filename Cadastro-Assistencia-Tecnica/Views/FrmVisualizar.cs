using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cadastro_Assistencia_Tecnica.Model;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Cadastro_Assistencia_Tecnica.Views
{
    public partial class FrmVisualizar : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        string filename = System.AppDomain.CurrentDomain.BaseDirectory + "output.pdf";



        public FrmVisualizar()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = MaterialSchemeColor.ThemeChanger();
        }

        private void FrmVisualizar_Load(object sender, EventArgs e)
        {         
            PDFView.src = filename;
        }

    }


}

