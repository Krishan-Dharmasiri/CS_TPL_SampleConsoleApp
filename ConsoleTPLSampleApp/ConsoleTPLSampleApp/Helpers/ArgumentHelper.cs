using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Helpers
{
    class ArgumentHelper
    {
        /*
         * KD: The purpose of this class is to get the argument array from the Main method and extract the arguments
         *     and transform those arguments the way we wanted them to be.
         *     for instance we can pass to say do a TestRun or do a Real Production Run
         *     or pass a date and Email Address which all the reports should be sent to
         */
        public ArgumentHelper(string[] Args)
        {
            foreach(var arg in Args)
            {
                Console.WriteLine(arg.ToString());
            }
        }
    }
}
