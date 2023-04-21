using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ejercicio: Simulará una caja de ahorro, la misma tendrá las siguientes propiedades:
//            - Numero de cuenta
//            - Saldo
//            - Titular
//            - Tipo de moneda
// Debe contener los siguientes metodos: Depositar / Extraer / Mostrar saldo

namespace EJ___Caja_de_ahorro
{
    public partial class FormAcceso : Form
    {
        public FormAcceso()
        {
            InitializeComponent();
        }

        // Funcion para verificar que los campos esten completos
        public bool verificar ()
        {
            if (boxTitular.Text == "" || ComboBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Funcion del boton "Aceptar" 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (verificar() == false)
            {
                MessageBox.Show("Debe completar todos los campos para continuar...");
            }
            else
            {
                // Imprimo número random de cuenta
                Random cuenta = new Random();
                int num = cuenta.Next(1, 150000);
                lblCuenta.Text = "Número de cuenta: " + num.ToString();
                double saldoinicial = 0;
                
                // Creo el objeto
                Cajadeahorro Cliente = new Cajadeahorro(num, boxTitular.Text, ComboBox.Text, saldoinicial);

                // Paso el objeto al siguiente form y abro el form
                FormCaja segundoForm = new FormCaja(Cliente);
                segundoForm.Show();
                this.Hide();
            }
        }
    }
}
