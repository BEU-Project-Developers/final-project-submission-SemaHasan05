using System.Threading;
using Task_2.Forms;

namespace Task_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Formları farklı thread'lerde başlat
            Thread thread1 = new Thread(() =>
            {
                Form1 form1 = new Form1();
                Application.Run(form1);
            });
            thread1.Start();

            Thread thread2 = new Thread(() =>
            {
                Form2 form2 = new Form2();
                Application.Run(form2);
            });
            thread2.Start();

            Thread thread3 = new Thread(() =>
            {
                Form3 form3 = new Form3();
                Application.Run(form3);
            });
            thread3.Start();

            Thread thread4 = new Thread(() =>
            {
                Form4 form4 = new Form4();
                Application.Run(form4);
            });
            thread4.Start();
        }
    }
}
