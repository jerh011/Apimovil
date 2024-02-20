using Corredores_f1_Api_JERH.view;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corredores_f1_Api_JERH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VCorredor();
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
