using System;
using System.Threading;

namespace CSharpAsyncBasic
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nStarting the application");
            DownloadSimulation();

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        static void DownloadSimulation()
        {
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Download Complete!");
            });
        }
    }
}