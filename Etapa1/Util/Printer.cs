using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibjarLinea(int tam = 15)
        {
            Console.WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {
            var tam = titulo.Length + 4;
            DibjarLinea(tam);
            Console.WriteLine($"| {titulo} |");
            DibjarLinea(tam);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}