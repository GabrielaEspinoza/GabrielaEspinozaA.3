using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Clases;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente clienteUno = 
                new Cliente("Lisbeth Gabriela", "Espinoza Delgado", 
                "e13170417", "Calle 119 avenida 103");
            Gasolina gasolinaUno = new Gasolina("Extra", 2, 3.00);

            Console.WriteLine(" \n *****   EMPRESA TERCER NIVEL Cía. Ltda. ***** ");
            Console.WriteLine(" \n DATOS DEL CLIENTE ");

            Console.WriteLine(" \n Nombres: {0}   \n Apellidos: {1}  \n Identificación: {2}  \n Dirección: {3}",
                    clienteUno.Nombres, clienteUno.Apellidos,  clienteUno.NumeroDeCedula, clienteUno.Direccion);
            Console.WriteLine("\n");

            Console.WriteLine(" DATOS DE LA GASOLINA ");

            Console.WriteLine(" \n Tipo de Gasolina: {0} \n Galones a compar: {1} \n Precio unitario: {2}",
                    gasolinaUno.TipoDeGasolina, gasolinaUno.CantidadDeGalones, gasolinaUno.PrecioDeVenta);
            Console.WriteLine("\n");

            Console.WriteLine(" FACTURA DE COMPRA ");
            Console.WriteLine("  \n  Subtotal: " + gasolinaUno.Subtotal);
            Console.WriteLine("  \n  Iva 12%:  " + gasolinaUno.Iva);

            Console.WriteLine("  \n  Total:    " + gasolinaUno.Total);

            Console.WriteLine("\n");
            Console.WriteLine("\n GRACIAS POR SU COMPRA." +
                "\n QUE TENGA UN HERMOSO DÍA.");



            Console.ReadKey();
        }
        
    }
}
