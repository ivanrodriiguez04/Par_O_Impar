using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_O_Impar.Servicios
{
    /// <summary>
    /// Clase interna que implementa a la interfaz
    /// 23102023 -> irm
    /// </summary>
    internal class ComprobacionImplementacion : ComprobacionInterfaz
    {
        public void comprobarNumero()
        {
            int numero=pedirNumero();

            if (numero % 2 == 0) 
            {
                Console.WriteLine("El numero introduciso es par");
            }
            else 
            {
                Console.WriteLine("El numero introducido es impar");
            }
        }

        /// <summary>
        /// Este metodo se utiliza para pedirle al usuario los numeros que desea comprobar
        /// 23102023 -> irm
        /// </summary>
        /// <returns></returns>
        private int pedirNumero() 
        {
            int numeroIntroducido;
            Console.WriteLine("Introduzca un numero:");
            numeroIntroducido=Convert.ToInt32(Console.ReadLine());
            return numeroIntroducido;
        }
    }
}
