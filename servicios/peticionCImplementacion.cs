using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4Bucles.servicios
{
    internal class peticionCImplementacion : peticionCInterfaz
    {
        public void ControlInteracion()
        {
            int numero;
            string respuesta;
            peticionCInterfaz pi = new peticionCImplementacion();
            operacionesInterfaz op = new operacionesImplementacion();

            do
            {
                numero = pi.PedirNumero();
                op.Multiplicacion(numero);
                respuesta = pi.RepetirNumero();

            } while (respuesta == "s");
        }

        public int PedirNumero()
        {
            int num;

            Console.WriteLine("Introduzca un número entero");
            num = Int32.Parse(Console.ReadLine());

            return num;
        }

        public string RepetirNumero()
        {
            string respuesta;

            Console.WriteLine("¿Quiere introducir un nuevo número?");
            respuesta = Console.ReadLine();

            return respuesta;
        }
    }
}
