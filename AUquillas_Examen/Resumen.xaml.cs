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
    public partial class Resumen : ContentPage
    {
        public Resumen(String Nombre, String Apellido, String Cuota,String Usuario,String montoInicial)
        {
            InitializeComponent();
            
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            lblUsuarioR.Text = Usuario;
            txtCuota.Text = Cuota;

            Double valorCuota= Convert.ToDouble(Cuota);
            Double valorInicial = Convert.ToDouble(montoInicial);
            Double valorTotal = 0;

            valorTotal = (valorCuota * 3) + valorInicial;
            txtTotal.Text = Convert.ToString(valorTotal);
        }
    }
}