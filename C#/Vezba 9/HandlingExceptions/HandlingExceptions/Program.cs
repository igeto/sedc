using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Couldn't find a .txt file with that name");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("I was right");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory path broken");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sostori ti glup");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally cock block!!!");
            }
            Console.ReadLine();
        }
    }
}
