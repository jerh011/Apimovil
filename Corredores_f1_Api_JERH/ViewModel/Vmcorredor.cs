using Corredores_f1_Api_JERH.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Corredores_f1_Api_JERH.ViewModel
{
    public class Vmcorredor : BaseViewModel
    {

        #region variable
            string _Id;
            string _Name;
            int _Number;
            string _Team;
        #endregion

        #region Procesos
        public Vmcorredor(INavigation naivigation)
        {
                Navigation = naivigation;

            
        }
        #endregion

        #region Objetos
        public string Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }
        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        }
        public int Numero
        {
            get { return _Number; }
            set { SetValue(ref _Number, value); }
        }
        public string Equipo
        {
            get { return _Team; }
            set { SetValue(ref _Team, value); }
        }
        #endregion

        #region Procesos

        public async Task Insertar()
        {
            MCorredor mcordor = new MCorredor
            {
                Name = Name,
                Number = Numero,
                Team = Equipo
            };

            Uri RequestUri = new Uri("http://www.Corredoresf1.somee.com/api/drivers");
            var client = new HttpClient();

            try
            {
                var json = JsonConvert.SerializeObject(mcordor);
                var contetJson = new StringContent(json, Encoding.UTF8, "Application/json");

                var response = await client.PostAsync(RequestUri, contetJson);

                if (response.StatusCode == HttpStatusCode.Created)
                    await DisplayAlert("Mensaje", "Registrado exitosamente", "Ok");
                else
                    await DisplayAlert("Mensaje", "Error al registrar", "Ok");
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada, por ejemplo, mostrando un mensaje de error
                await DisplayAlert("Mensaje", "Error: " + ex.Message, "Ok");
            }
        }

        #endregion




        #region Comandos

        public ICommand Registrarcommand => new Command(async () => await Insertar());
        #endregion
    }
}