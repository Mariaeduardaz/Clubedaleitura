using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    class Menurevista
    {
        public int opcaodomenu;
        public int Menuprincipal()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem Vindos");
            Console.ResetColor();
            Console.WriteLine("\nDigite 1 para adcionar alguma revista ");
            Console.WriteLine("\nDigite 2 para adcionar uma caixa");
            Console.WriteLine("\nDigite 3 para adicionar um amigo");
            Console.WriteLine("\nDigite 4 para fazer um emprestimo");
            
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Digite 5 para ver as revistas");
            Console.WriteLine("Digite 6 para ver as caixas que foram cadastradas");
            Console.WriteLine("Digite 7 para ver os amigos que foram cadastrados");
            Console.WriteLine("Digite 8 para ver os emprestimos feitos");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------------------------------");
            Console.ResetColor();
            opcaodomenu = Convert.ToInt32(Console.ReadLine());
            return opcaodomenu;
            Console.ReadLine();
        }
        
        






    }
}
