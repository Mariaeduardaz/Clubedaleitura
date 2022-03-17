using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    class Pessoa
    {
        public string telefone;
        public string nomedoresponsavel, nome;
        public string endereco;
        public bool Emprestimo; public bool possuirevista;
        public void Registrar()
        {
            Console.WriteLine("qual seu telefone = ");
            telefone = Console.ReadLine();
            Console.WriteLine("qual é o nome do responsavel = ");
            nomedoresponsavel = Console.ReadLine();
            Console.WriteLine("qual seu endereco = ");
            endereco = Console.ReadLine();
            Console.WriteLine("qual seu nome = ");
            nome = Console.ReadLine();
             
            Console.WriteLine("Deu certo, pessoa registrada :)");

        }
        public void MostraroRegistropessoa()
        {
            Console.WriteLine("Seu amigo" + nome);
            Console.WriteLine("O telefone" + telefone);
            Console.WriteLine("O nome do responsavel" + nomedoresponsavel);
            Console.WriteLine("O endereço" + endereco);


            if (possuirevista == true) 
                Console.WriteLine("seu amigo ja pegou uma revista");
            else

            Console.WriteLine("seu amigo não pegou nenhuma revista ainda");


            Console.ReadLine();
        }

    }
}
