using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using System.Configuration;

namespace Cadastro_Assistencia_Tecnica.Model
{
    static class MaterialSchemeColor
    {

        public static int red;
        public static int green;
        public static int blue;

        public static int colorSchemeIndex = Convert.ToInt16(ConfigurationManager.AppSettings["index"].ToString());

        public static ColorScheme ThemeChanger()
        {
            UpdateSetting(colorSchemeIndex);
            switch (colorSchemeIndex)
            {
                case 0:
                    red = 55;
                    green = 71;
                    blue = 79;
                    return new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

                case 1:
                    red = 63;
                    green = 81;
                    blue = 181;
                    return new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

                case 2:
                    red = 85;
                    green = 45;
                    blue = 168;
                    return new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple800, Primary.Indigo100, Accent.Red100, TextShade.WHITE);

                case 3:
                    red = 2;
                    green = 119;
                    blue = 189;
                    return new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue800, Accent.Red100, TextShade.WHITE);

                default:
                    red = 55;
                    green = 71;
                    blue = 79;
                    return new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            }


        }

        public static ColorScheme ChangeColor()
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 3) colorSchemeIndex = 0;

            return ThemeChanger();
        }


        private static void UpdateSetting(int vr)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["index"].Value = vr.ToString();

            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }


    }
}
