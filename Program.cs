using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFAB_builder
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logger.Info("Starts app with params:", Assembly.GetCallingAssembly().GetName().Version.ToString()
                , Assembly.GetCallingAssembly().GetName().Name
                , DateTime.Now.ToString()
                , $"Game version: {GameVersion}");
            Application.Run(new MainMenuForm());
        }

        public static string GameVersion { get; set; } = "8.4";
    }
}
