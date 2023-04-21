using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ___Caja_de_ahorro
{
    public class Cajadeahorro
    {
        // Atributos privados
        private int _numcuenta;
        private string _titular;
        private string _moneda;
        private double _saldo;

        // Propiedades para leer y escribir los atributos
        public int Numcuenta
        {
            get { return _numcuenta; }
        }
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public string Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        // Constructor (inicializa los atributos con los parametros)
        public Cajadeahorro(int numerodecuenta, string nombre, string moneda, double saldo)
        {
            this._numcuenta = numerodecuenta;
            this._titular = nombre;
            this._moneda = moneda;
            this._saldo = saldo; 
        }

        // Metodo de la clase para depositar (suma el parametro al atributo "Saldo")
        public void Depositar(double depo)
        {
            this.Saldo += depo;
        }

        // Metodo de la clase para extraer (resta el parametro al atributo "Saldo")
        public bool Extraer(double extr)
        {
            if (extr > 0)
            {
                if (Saldo >= extr)
                {
                    this.Saldo -= extr;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false; 
            }
        }
    }
}
