using System;

namespace pooDestruidores
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferramenta f1 = new Ferramenta("Martelo");
            Ferramenta f2 = new Ferramenta("Martelete");
            f1 = null;
            f2 = new Ferramenta("Marreta");

            GC.Collect();
            Console.ReadKey();
        }
    }
}
