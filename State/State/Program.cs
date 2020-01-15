using State.Services;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Incializa la aplicación.
        /// </summary>
        public static void InicializarAplicacion()
        {
            // The client code.
            string cOpcion = string.Empty;
            Console.WriteLine("Estado Inicial de la alarma Activa");
            AlarmaActiva alarmaActiva = new AlarmaActiva();            
            var context = new AlarmaContext(alarmaActiva);
            alarmaActiva.SetContext(context);
            do
            {
                ImprimirMenu();
                cOpcion = Console.ReadLine();
                ValidarOpcion(cOpcion, context);
            }
            while (cOpcion != string.Empty);

            Console.ReadKey();
        }

        /// <summary>
        /// Imprime el menu.
        /// </summary>
        public static void ImprimirMenu()
        {
            Console.WriteLine("\r\n¿Que desea hacer?");
            Console.WriteLine("1.-Activar");
            Console.WriteLine("2.-Inactivar");
        }

        /// <summary>
        /// Validar opción de estado de la alarma.
        /// </summary>
        /// <param name="_cOpcion">Opción seleccionada.</param>
        /// <param name="_context">Contexto que majeja el estatus de la alarma.</param>
        public static void ValidarOpcion(string _cOpcion, AlarmaContext _context)
        {
            switch (_cOpcion)
            {
                case "1":
                    _context.Activar();
                    break;
                case "2":
                    _context.Inactivar();
                    break;
                default:
                    Console.WriteLine("Opción No válida");
                    _cOpcion = "X";
                    break;
            }
        }
    }
}
