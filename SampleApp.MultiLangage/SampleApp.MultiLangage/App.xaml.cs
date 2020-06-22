using SampleApp.MultiLangage.Resources;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.MultiLangage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Plugin.XF.MultiLanguage.StringLoader.Instance.Init(StringRes.ResourceManager);
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
