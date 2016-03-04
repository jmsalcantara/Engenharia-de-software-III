using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais brasil = new Pais("BRA", "Brasil", 40924024);
            brasil.populacao = 121212;
            Pais uruguai = new Pais("URU", "Uruguai", 3203113);
            uruguai.populacao = 120945;
            Pais argentina = new Pais("ARG", "Argentina", 232390);
            argentina.populacao = 399394;
            Pais colombia = new Pais("COL", "Colombia", 13093);
            colombia.populacao = 230203;
            Pais venezuela = new Pais("VEN", "Venezuela", 13093);
            venezuela.populacao = 230203;

            Continente americaDoSul = new Continente("America do Sul");

            americaDoSul.AddPais(brasil);
            americaDoSul.AddPais(uruguai);
            americaDoSul.AddPais(argentina);
            americaDoSul.AddPais(colombia);
            americaDoSul.AddPais(venezuela);

            Console.WriteLine("Densidade populacional: " + americaDoSul.GetDensidadePopulacional());
            Console.WriteLine("Populacao: " + americaDoSul.GetPopulacao());
            Console.WriteLine("Dimensao: " + americaDoSul.GetDimensao());

            brasil.fronteiras.Add(argentina);
            brasil.fronteiras.Add(colombia);
            uruguai.fronteiras.Add(argentina);
            uruguai.fronteiras.Add(colombia);

            List<Pais> emComum = brasil.VizinhosEmComum(uruguai);

            Console.WriteLine("Vizinhos em comum: ");
            foreach (var item in emComum)
            {
                Console.WriteLine(item.nome);
            }
        }
    }
}
