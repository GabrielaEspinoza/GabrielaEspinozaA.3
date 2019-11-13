using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Gasolina
    {

        

        private string tipoDeGasolina;

        public string TipoDeGasolina
        {
            get { return tipoDeGasolina; }
            set { tipoDeGasolina = value; }
        }

        private double cantidadDeGalones;

        public double CantidadDeGalones
        {
            get { return cantidadDeGalones; }
            set { cantidadDeGalones = value; }
        }

        private double precioDeVenta;

        public double PrecioDeVenta
        {
            get
            {
                if (TipoDeGasolina == "* Super *")
                {
                    precioDeVenta = 2.00;
                }
                if (TipoDeGasolina == "* Extra *")
                {
                    precioDeVenta = 1.50;
                }
                return precioDeVenta;
            }

        }

        private double subtotal;

        public double Subtotal
        {
            get { return (PrecioDeVenta * CantidadDeGalones); }

        }

        private double iva;

        public double Iva
        {
            get { return (Subtotal * 0.12); }

        }

        private double  total;

        public Gasolina(string tipoDeGasolina, double cantidadDeGalones, double precioDeVenta)
        {
            this.tipoDeGasolina = tipoDeGasolina;
            this.cantidadDeGalones = cantidadDeGalones;
            this.precioDeVenta = precioDeVenta;

        }

        public double Total
        {
            get { return (Subtotal + Iva ); }
            
        }



    }
}
