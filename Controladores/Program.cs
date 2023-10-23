using Par_O_Impar.Servicios;

namespace Par_O_Impar.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 23102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos
            ComprobacionInterfaz cI = new ComprobacionImplementacion();

            cI.comprobarNumero();

        }
    }
}
