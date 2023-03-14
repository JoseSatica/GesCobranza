using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            try
            {
                Application.Run(new Login());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error del Sistema");
            }
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            
        }
    }
}
