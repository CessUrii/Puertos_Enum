using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Puertos_Enum
{
    internal class Program
    {
        public enum Socket
        {

            [Description("Expresion Regular")]
            puerto1 = 8980,

            [Description("Calculadora")]
            puerto2 = 8981,

            [Description("Base de datos")]
            puerto3 = 8982,

            puerto4 = 8983,
            puerto5 = 8984,
            puerto6 = 8985,
            puerto7 = 8986,
            puerto8 = 8987,
            puerto9 = 8988,
            puerto10 = 8989,
            puerto11 = 8990,
        }

        static void Main(string[] args)
        {
            bool condicion = true;
            do
            {
                Console.WriteLine("Ingresa el numero de puerto que deseas activar");
                int puerto = Convert.ToInt32(Console.ReadLine());

                switch ((Socket)puerto)
                {
                    case Socket.puerto1:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Expresion Regular");
                        condicion = false;
                        break;
                    case Socket.puerto2:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Calculadora");
                        condicion = false;
                        break;
                    case Socket.puerto3:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Base de datos");
                        condicion = false;
                        break;
                    case Socket.puerto4:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto5:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto6:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto7:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto8:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto9:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto10:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    case Socket.puerto11:
                        Console.WriteLine("Configurado el puerto " + puerto + ", Nombre aun no definido");
                        condicion = false;
                        break;
                    default:
                        Console.WriteLine("No existe el puerto " + puerto);
                        break;
                }

            } while (condicion);

            Console.ReadKey();
        }
    }
}
