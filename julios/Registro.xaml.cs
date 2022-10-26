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
            double nota = Convert.ToDouble(txtNota1.Text);
            var nota1 = double.Parse(txtNota1.Text);
            var nota2 = double.Parse(txtNota2.Text);
            var nota3 = nota1 + nota2;
            txtNota3.Text = nota3.ToString();

            txtNota3.Text = txtNota3.ToString();


            var nota4 = double.Parse(txtNota4.Text);
            var nota5 = double.Parse(txtNota5.Text);
            var nota6 = nota4 + nota5;
            txtNota6.Text = nota6.ToString();

            var nota7 = nota3 + nota5;
            txtNota7.Text = nota7.ToString();




            if (nota7 >= 7)
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es " + nombre + "\nTu apellido es " + apellido + "\nAPROBASTE CON" + nota7, "\nCerrar");
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es" + nombre + "\nTu apellido es " + apellido + "\nREPROBASTE CON" + nota7, "Cerrar");
            }
        }
    }
}