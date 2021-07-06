using System;

namespace pooDestruidores
{
    public class Ferramenta
    {
        public Ferramenta(string nome)
        {
            this.Nome = nome;
        }

        ~Ferramenta()
        {
            Console.WriteLine("A sua ferramenta " + this.Nome + " foi destruida");
        }
        public string Nome { get; set; }

    }
}
