using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AUquillas_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private async void bntCalcular_Clicked(object sender, EventArgs e)
        {
            Double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            Double pagoMensual = 0;
            Double cuotaTotal = 0;
            try
            {

                if (montoInicial == 1800)
                {
                    await DisplayAlert("Alerta", "Ud ha cancelado toda su deuda", "Ok");
                }
                if (montoInicial < 0 || montoInicial > 1800)
                {
                    await DisplayAlert("Error", "Valor del monto inicial no es valido.", "Ok");
                }

                else
                {
                    pagoMensual = (1800 - montoInicial) / 3;
                    cuotaTotal = Math.Round((1800 * 0.05) + pagoMensual, 2);
                    txtCuota.Text = Convert.ToString(cuotaTotal);

                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                String usuario = Convert.ToString(lblUsuario.Text);
                String nombre= Convert.ToString(txtNombre.Text);
                String apellido= Convert.ToString(txtApellido.Text);
                
                if (string.IsNullOrEmpty(txtMontoInicial.Text))
                {
                    await DisplayAlert("Error", "Debe ingresar un monto inicial", "Ok");
                }
                else
                {
                    bool opcion = await DisplayAlert("Confirmación", "¿Está deacuerdo con la cuota a pagar mensualmente?", "Si", "No");
                    if (opcion == true)
                    {
                        await DisplayAlert("Alerta", "Elemento guardado con exito.", "OK");
                        await Navigation.PushModalAsync(new Resumen(usuario,nombre,apellido));
                    }
                }
            }
            catch (Exception exc)
            {
                DisplayAlert("Alerta", exc.Message, "Ok");
            }
        }
    }
}