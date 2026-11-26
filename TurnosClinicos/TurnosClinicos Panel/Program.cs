using TurnosClinicos.UI;

namespace TurnosClinicos_Panel
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmTurnos());
        }
    }
}