using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    internal class ACaixa
    {
        public int numerodaCaixa;
        public string cor;
        public string etiqueta;
     

        public int caixadarevista;
        public void registrandoacaixa()
        {
            Console.WriteLine("qual o numero da caixa?" );
            numerodaCaixa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("qual a cor da sua caixa? ");
            cor = Convert.ToString(Console.ReadLine());

            Console.WriteLine("qual a sua etiqueta?" );
            etiqueta = Convert.ToString(Console.ReadLine());


        }
        public void mostrarregistrocaixa()
        {
            Console.WriteLine("numero da caixa" + numerodaCaixa);
            Console.WriteLine("cor da caixa" + cor);
            Console.WriteLine("etiqueta" + etiqueta);

            Console.ReadLine();
        }

        
      


            

            






        
    }
}
