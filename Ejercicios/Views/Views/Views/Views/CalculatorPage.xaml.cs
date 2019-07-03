using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Views
{
    public enum Operacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage ()
		{
			InitializeComponent ();
		}
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            ResultadoLabel.Text += ((Button)sender).Text;
        }

        double operador1 = 0, operador2 = 0;
        Operacion _operacion;

        private void Button_Equals_Clicked(object sender, EventArgs e)
        {
            EstableceOperador2();
            switch(_operacion)
            {
                case Operacion.Suma:
                    Mostrar(operador1 + operador2);
                    break;
                case Operacion.Resta:
                    Mostrar(operador1 - operador2);
                    break;
                case Operacion.Multiplicacion:
                    Mostrar(operador1 * operador2);
                    break;
                case Operacion.Division:
                    Mostrar(operador1 / operador2);
                    break;
            }
        }

        private void Button_OperationSuma_Clicked(object sender, EventArgs e)
        {
            _operacion = Operacion.Suma;
            EstableceOperador1();
        }

        private void EstableceOperador1()
        {
            operador1 = Convert.ToDouble(ResultadoLabel.Text);
            BorrarResultado();
        }

        private void EstableceOperador2()
        {
            operador2 = Convert.ToDouble(ResultadoLabel.Text);
        }

        private void Button_OperationResta_Clicked(object sender, EventArgs e)
        {
            _operacion = Operacion.Resta;
            EstableceOperador1();
        }

        private void Button_OperationMultiplicacion_Clicked(object sender, EventArgs e)
        {
            _operacion = Operacion.Multiplicacion;
            EstableceOperador1();
        }

        private void Button_OperationDivision_Clicked(object sender, EventArgs e)
        {
            _operacion = Operacion.Division;
            EstableceOperador1();
        }

        private void Button_Borrar_Clicked(object sender, EventArgs e)
        {
            ResultadoLabel.Text = ResultadoLabel.Text.Length > 0
                                    ? ResultadoLabel.Text.Substring(0, ResultadoLabel.Text.Length - 1)
                                    : "";
        }

        private void Button_Limpiar_Clicked(object sender, EventArgs e)
        {
            BorrarResultado();
        }

        private void BorrarResultado()
        {
            ResultadoLabel.Text = "";
        }

        private void Mostrar(double resultado)
        {
            ResultadoLabel.Text = resultado.ToString();
        }
    }
}