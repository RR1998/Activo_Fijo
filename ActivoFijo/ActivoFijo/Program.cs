using System;
using System.Windows.Forms;
using ActivoFijo.Login_and_Register;
using ActivoFijo.Login_and_Register.AlterarUsuario;

namespace ActivoFijo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
