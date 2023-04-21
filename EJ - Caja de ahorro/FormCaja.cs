using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ___Caja_de_ahorro
{
    public partial class FormCaja : Form
    {
        // Pasaje del objeto creado en el otro form
        private Cajadeahorro Cliente;
        public FormCaja(Cajadeahorro cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            lblTitulo.Text = "Caja de ahorro en " + Cliente.Moneda;
            lblnumero.Text = "N° de cuenta: " + Cliente.Numcuenta;
            lblperson.Text = "Titular: " + Cliente.Titular; 
        }

        // Funcion del boton "Mostar saldo actual"
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblPlata.Text = "$ " + Cliente.Saldo;
        }

        // Funcion del boton "Depositar"
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (Boxdepositar.Text == "")
            {
                MessageBox.Show("Debe colocar el monto a depositar para continuar...");
            }
            else
            {
                double depositar = double.Parse(Boxdepositar.Text);
                // Utilizo metodo de la clase "Cajadeahorro"
                Cliente.Depositar(depositar);
                MessageBox.Show("Su deposito se realizo con exito!!");
                Boxdepositar.Text = "";
            }
        }

        // Funcion del boton "Extraer"
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (Boxextraer.Text == "")
            {
                MessageBox.Show("Debe colocar el monto a extraer para continuar...");
            }
            else 
            {
                double extraer = double.Parse(Boxextraer.Text);
                // Utilizo metodo de la clase "Cajadeahorro"
                if (Cliente.Extraer(extraer) == false)
                {
                    MessageBox.Show("El monto ingresado es negativo o su saldo es insuficiente");
                    Boxextraer.Text = "";
                }
                else
                {
                    Cliente.Extraer(extraer);
                    MessageBox.Show("Su extracción se realizo con exito!!");
                    Boxextraer.Text = "";
                }
            }
        }

        // Boton para terminar la ejecucion del programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
                
