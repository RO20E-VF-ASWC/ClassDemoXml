using System;

namespace ClassDemoXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWorker worker = new XmlWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
