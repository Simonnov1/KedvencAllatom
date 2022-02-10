using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KedvencAllatom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi a kedvenc állatod?");
            string Allat = Console.ReadLine();
            string enyem = "majom";
            Console.WriteLine("A kedvenc állatod: " + Allat);
            Console.WriteLine("Az én kedvenc állatom pedig a " + enyem);
            if (Allat == "majom")
	        {
                Console.WriteLine("Szóval elég menő, hogy ugyanaz a kedvenc állatunk");
	        }
        }
    }
}
