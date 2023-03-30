using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaManipulaçãostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase");
            string fraseUsuario = Console.ReadLine();

            string[] palavras = fraseUsuario.Split(' ');

            string TitleCase = " ";

            foreach (string letra in palavras)
            {
               TitleCase += char.ToUpper(letra[0]) + letra.Substring(1).ToLower() + " ";
            }


            Console.WriteLine(TitleCase);

            Console.ReadLine();

        }
    }
}
