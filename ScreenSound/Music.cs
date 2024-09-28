using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Music
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Duration { get; set; }
        public bool IsAvaliable { get; set; }
        public string Description => $"A musica {Name} pertence ao artista {Author}";

        public void ShowMusic()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Artista: {Author}");
            Console.WriteLine($"Duração: {Duration}");

            //Condição ternaria
            string disponivel = IsAvaliable == true ? "Sim" : "Não"; 

            Console.WriteLine($"Disponivel: {disponivel}");

        }
    }


}
