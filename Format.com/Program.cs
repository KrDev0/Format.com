using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Format.com
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verificar si se pasó un argumento (la letra de la unidad).
            string driveLetter = args.Length > 0 ? args[0] : null;

            // Limpiar el argumento: eliminar comillas y espacios.
            if (!string.IsNullOrEmpty(driveLetter))
            {
                driveLetter = driveLetter.Replace("\"", "").Trim(); // Eliminar comillas y espacios.
            }
            // Pasar el argumento al formulario principal.
            Application.Run(new Form1(driveLetter));
        }
    }
}
