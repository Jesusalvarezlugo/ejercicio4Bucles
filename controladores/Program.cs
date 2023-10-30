using ejercicio4Bucles.servicios;

namespace ejercicio4Bucles.controladores
{
    class Program
    {
        static void Main(string[] args)
        {

            peticionCInterfaz pi = new peticionCImplementacion();

            pi.ControlInteracion();
        }
    }
}
