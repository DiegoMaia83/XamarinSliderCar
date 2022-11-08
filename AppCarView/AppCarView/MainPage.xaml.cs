using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCarView
{
    public partial class MainPage : ContentPage
    {
        int fotoAtual = 1;
        int primeiraFoto = 1;
        int ultimaFoto = 4;

        public MainPage()
        {
            InitializeComponent();
        }

        public void IncrementaFoto(object sender, EventArgs e)
        {
            if (fotoAtual == ultimaFoto)
            {
                fotoAtual = primeiraFoto;
            }
            else
            {
                fotoAtual++;
            }            

            AtualizaFoto(fotoAtual);
        }

        public void DecrementaFoto(object sender, EventArgs e)
        {
            if (fotoAtual == primeiraFoto)
            {
                fotoAtual = ultimaFoto;
            }
            else
            {
                fotoAtual--;
            }
            AtualizaFoto(fotoAtual);
        }

        public void AtualizaFoto(int numeroFoto)
        {
            var foto = new StringBuilder();
            foto.AppendFormat("{0}{1}{2}", "car_", numeroFoto, ".jpg");

            imgCar.Source = foto.ToString();
            lbDescricao.Text = RetornaTexto(numeroFoto);
        }

        public string RetornaTexto(int numeroFoto)
        {
            var texto = "";

            switch (numeroFoto)
            {
                case 1:
                    texto = "Vista frontal";
                    break;
                case 2:
                    texto = "Vista lateral esquerda";
                    break;
                case 3:
                    texto = "Vista lateral direita";
                    break;
                case 4:
                    texto = "Vista traseira";
                    break;
            }

            return texto;
        }
    }
}
