using Corredores_f1_Api_JERH.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Corredores_f1_Api_JERH.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VCorredor : ContentPage
    {
        public VCorredor()
        {
            InitializeComponent();
            BindingContext = new Vmcorredor(Navigation);
        }
    }
}