using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntoSecorro
{
    public class MainTest
    {
        public static void Main()
        {
            StreamWriter sw;
            string caminho = "C:\\Users\\rcostame\\Desktop\\ProntoSecorro.log";
            sw = File.CreateText(caminho);
            Console.ReadKey();
        }
    }
}
