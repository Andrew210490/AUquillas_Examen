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
        public Resumen(String Nombre, String Apellido,String Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            

        }
    }
}