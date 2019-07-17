using System;

namespace ConsoleTPLSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/Krishan-Dharmasiri/CS_TPL_SampleConsoleApp.git

            /*
             * 1. Create an instance of the Argument helper class and parse arguments coming to the main method
             * 2. Create an instance of the report group class, and set all the report group specific data
             * 3. Get all the reports that belong to this group from the DB, that includes the DLL that reports belong to and 
             *    also the code files (.cs) file. reports can belong to more than one DLL.
             * 4. Run reports concurrently   
             * 5. Send emails to the relevant parties (like summary email)
             */

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
