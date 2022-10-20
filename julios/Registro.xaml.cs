using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace julios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            double nota = Convert.ToDouble(txtNota.Text);
        }
    }
}