using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    public class Rettangolo
    {
        private readonly double @Base;
        private readonly double Altezza;
        private string NomeCostruttore;

        public Rettangolo (double @Base, double Altezza)
        {
            this.@Base = @Base;
            this.Altezza = Altezza;
            this.NomeCostruttore = "Rettangolo";
        }

        public double Area()
        {
            return @Base * Altezza;
        }

        public double Perimetro()
        {
            return (2 * @Base) + (2 * Altezza);
        }

        public void StampaRettangolo()
        {
             Console.WriteLine("Nome:{0} Base: {1}cm Altezza: {2}cm Area: {3}cm2 perimetro: {4}cm", NomeCostruttore, @Base, Altezza, Area(), Perimetro());
        }

        public void Disegna()
        {
            Console.Write("+");
            for (int i = 1; i < (@Base - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");

            for (int i = 1; i < (Altezza - 1); ++i)
                Console.WriteLine("|{0}|", new String(' ', (int)(@Base - 2)));

            Console.Write("+");
            for (int i = 1; i < (@Base - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");
        }
    }
}
