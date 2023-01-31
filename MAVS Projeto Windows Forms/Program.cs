using Microsoft.EntityFrameworkCore;

namespace MAVS_Projeto_Windows_Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Application.ExecutablePath));
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
