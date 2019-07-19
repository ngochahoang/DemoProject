using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExtraClassUI
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
            //Initialize database connection
            ExtraClassLibrary.GlobalConfig.InitializeConnections(ExtraClassLibrary.DatabaseType.Sql);
            Application.Run(new CreateUserForm());
        }
    }
}
