using Enrollment_System.Entity_Class;
using Enrollment_System.Screens;
using System.Net;
using System.Net.Mail;

namespace Enrollment_System
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}
