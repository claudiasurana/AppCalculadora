using System.Xml.Linq;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e) // Todos los botones van a llamar a esta función
        {
            var boton = ((Button)sender); // Se obtiene el botón pulsado y sus propiedades

            if (textResultado.Text == "0")
            {
                textResultado.Text = "";
            }

            textResultado.Text += boton.Text;
        }

        private void operacion(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            num1 = double.Parse(textResultado.Text);
            operador = char.Parse(boton.Text);

            textResultado.Text = "";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textResultado.Text);

            if (operador == '+')
            {
                textResultado.Text = (num1 + num2).ToString();
                num1 = double.Parse(textResultado.Text); // Para concatenar operaciones
            }
            else if (operador == '-')
            {
                textResultado.Text = (num1 - num2).ToString();
                num1 = double.Parse(textResultado.Text); 
            }
            else if (operador == '*')
            {
                textResultado.Text = (num1 * num2).ToString();
                num1 = double.Parse(textResultado.Text); 
            }
            else if (operador == '/')
            {
                textResultado.Text = (num1 / num2).ToString();
                num1 = double.Parse(textResultado.Text); 
            }


        }

        //Si solo hay un caracter se convierte en 0, si hay más de uno se borra solo el último
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Length > 1)
            {
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
            }
            else
            {
                textResultado.Text = "0";
            }
        }

        // Borra todo lo almacenado
        private void buttonC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            textResultado.Text = "0";
        }

        // Borra lo que aparece en pantalla
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
        }

        // Si no hay punto, agregar uno al pulsar el botón del decimal
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains("."))
            {
                textResultado.Text += ".";
            }
        }

        private void buttonSigno_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textResultado.Text);
            num1 *= -1;
            textResultado.Text = num1.ToString();
        }
    }
}