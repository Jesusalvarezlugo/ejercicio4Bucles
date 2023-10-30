using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4Bucles.servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void Multiplicacion(int num)
        {
            int i;
            int multiplicacion=1;

            for (i = 1; i <= num; i++)
            {
                multiplicacion = multiplicacion * i;
            }

            Console.WriteLine("La multiplicacion es:{0}", multiplicacion);

            
        }
    }
}
