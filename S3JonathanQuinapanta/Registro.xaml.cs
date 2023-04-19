using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3JonathanQuinapanta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string datoUno, string datoDos)
        {
            InitializeComponent();
            lblDato1.Text = datoUno;
            txtDato2.Text = datoDos;
        }
    }
}