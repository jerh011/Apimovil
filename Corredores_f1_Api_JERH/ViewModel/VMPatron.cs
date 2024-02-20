using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Corredores_f1_Api_JERH.ViewModel
{
    public class VMPatron:BaseViewModel
    {
        public VMPatron(INavigation naivigation)
        {
            Navigation = naivigation;

        }

        #region Procesos

        public async Task IncioSecion()
        {

            await Navigation.PushAsync(new MainPage());
        }
        #endregion




        #region Comandos

        public ICommand Monitoreocommand => new Command(async () => await IncioSecion());
        #endregion
    }
}