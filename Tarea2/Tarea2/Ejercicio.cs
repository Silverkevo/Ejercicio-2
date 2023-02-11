using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Ejercicio : Form
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        private async Task<double> CalcularPromedioAsync(double n1 ,double n2, double n3 , double n4)
        {
            
            double Promedio = await Task.Run(() =>
            {
                return n1 + n2 + n3 + n4 ; 
            });
            return Promedio / 4;
        }


        private async void CalcularAsyncButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Nota1TextBox.Text);
            double num2 = Convert.ToDouble(Nota2TextBox.Text);
            double num3 = Convert.ToDouble(Nota3TextBox.Text);
            double num4 = Convert.ToDouble(Nota4TextBox.Text);

            if (num1 >100)
            {
                errorProvider1.SetError(Nota1TextBox, "Ingrese un valor entre 0 a 100 ");
                return;
            }
            errorProvider1.Clear();
            if (num2 > 100)
            {
                errorProvider1.SetError(Nota2TextBox, "Ingrese un valor entre 0 a 100 ");
                return;
            }
            errorProvider1.Clear();
            if (num3 > 100)
            {
                errorProvider1.SetError(Nota3TextBox, "Ingrese un valor entre 0 a 100 ");
                return;
            }
            errorProvider1.Clear();
            if (num4 > 100)
            {
                errorProvider1.SetError(Nota4TextBox, "Ingrese un valor entre 0 a 100 ");
                return;
            }
            errorProvider1.Clear();

            double resultado = await CalcularPromedioAsync(num1, num2, num3, num4);

            MessageBox.Show($"Su Promedio Final en la Clase es: {resultado}");

            Nota1TextBox.Clear();
            Nota2TextBox.Clear();
            Nota3TextBox.Clear();
            Nota4TextBox.Clear();
            Nota1TextBox.Focus();

        }




    }
}
