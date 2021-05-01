using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AUquillas_Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void bntIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                String usuario = Convert.ToString(txtUsuario.Text);
                String clave = Convert.ToString(txtPsdw.Text);

                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    await DisplayAlert("Error", "El usuario esta vacio", "Ok");
                    txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPsdw.Text))
                {
                    await DisplayAlert("Error", "La contraseña esta vacia", "Ok");
                    txtPsdw.Focus();
                    return;
                }

                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new Registro(usuario));
                }
                else
                {
                    DisplayAlert("Error", "Credenciales incorrectas, por favor vualva a ingresar", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Ok");
            }

        }
    }
}
