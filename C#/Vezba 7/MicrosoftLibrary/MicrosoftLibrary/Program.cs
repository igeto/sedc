using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = @"C:\Users\code\Desktop\C#\Vezba 7\MicrosoftLibrary\test.txt";

            //File.WriteAllText(address, "This is the test value");
            //Console.WriteLine(File.ReadAllText(address));

            WebClient client = new WebClient();
            string content = client.DownloadString("http://msdn.microsoft.com");
            Console.WriteLine(content);
            File.WriteAllText(address, content);

            Console.ReadLine();
        }
    }
}
