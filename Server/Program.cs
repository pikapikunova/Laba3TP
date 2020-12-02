using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClassLibrary.Class1));
            host.Open();
            Console.WriteLine("Сервис запущен");
            Console.ReadLine();
            host.Close();
        }
    }
}
