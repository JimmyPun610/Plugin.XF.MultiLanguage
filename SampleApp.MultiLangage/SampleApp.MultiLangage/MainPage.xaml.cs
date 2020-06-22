using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp.MultiLangage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            setLanguage(1033);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            setLanguage(1028);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            setLanguage(3082);
        }
        private void setLanguage(int languageCode)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCode);
            Plugin.XF.MultiLanguage.StringLoader.Instance.SetCultureInfo(new CultureInfo(languageCode));
        }
    }
}
