using System;
using System.Diagnostics;
using KeyEvents;

namespace Blacklinux
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Blacklinux";
            
            string WslStart = "-d Blacklinux";
            Process.Start("wsl.exe", WslStart);
        }
    }
}
