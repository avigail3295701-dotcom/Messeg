using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Messeg
{
    internal class Program
    {
        public static void Mess(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            Messeger m = new Messeger();
            m.MessegerReceived += Mess;
            m.Mess("Avigail");
        }
    }
}
