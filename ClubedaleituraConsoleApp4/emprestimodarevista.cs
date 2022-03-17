using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    internal class Emprestimodarevista
    {
        int numerodarevista;
        int numerodoamiguinho;
        public Pessoa amigopegouarevista;
        public bool emprestimoparaoamigoaberto;
        public Revista revistaemprestadaparaoamigo;
        public DateTime dataquefoiemprestada;
        public DateTime datadedevolucao;



        public void Emprestimo (CadastroDaRevista[] revista, Pessoa[] pessoa)
        {
            emprestimoparaoamigoaberto = true;
            Console.WriteLine("A data do emprestimo é");
            dataquefoiemprestada = DateTime.Parse(Console.ReadLine());

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null) 
                continue;

                Console.WriteLine($" A revista {revista[i].anodaRevista} || aqui esta sua colecao {revista[i].tipodeColecao} || numero da edição {revista[i].numerodaEdicao} || revista numero {i}");

            }
            do
            {
                Console.WriteLine("qual revista voce quer emprestar para o seu amigo?");
            } while (!(int.TryParse(Console.ReadLine(), out numerodarevista)) || revista[numerodarevista] == null || revista[numerodarevista].revistaDisponivel == false);
            
            revista[numerodarevista].revistaDisponivel = false;

            for (int j = 0; j < pessoa.Length; j++)
            {
                if (pessoa[j] == null) continue;

                Console.WriteLine($"O nome do seu amigo {pessoa[j].nome} o endereco {pessoa[j].endereco} o nome do responsavel {pessoa[j].nomedoresponsavel} amigo numero {j}");

            }
            do
            {
                Console.WriteLine("Qual dos seus amigos deseja pegar a revista emprestada? ");
            } while (!(int.TryParse(Console.ReadLine(), out numerodoamiguinho)) || pessoa[numerodoamiguinho] == null || pessoa[numerodoamiguinho].possuirevista);
            amigopegouarevista = pessoa[numerodoamiguinho];

            pessoa[numerodoamiguinho].possuirevista = true;
            Console.WriteLine("revista foi emprestada com sucesso :)");

            
        }
        public void Fecharosemprestimos()
        {
            emprestimoparaoamigoaberto = false;
            Console.WriteLine("Quando seu amigo devolveu a revista? ");
            datadedevolucao = DateTime.Parse(Console.ReadLine());
        }
        public void RegistrarEmprestimo()
        {
            Console.WriteLine("Nome do responsavel " + amigopegouarevista.nomedoresponsavel);
            Console.WriteLine("Nome do seu amigo que pegou a revista " + amigopegouarevista.nome);
            Console.WriteLine("Qual o dia que ele pegou a revista" + dataquefoiemprestada);

            if (emprestimoparaoamigoaberto == true)
            {
                Console.WriteLine("Pode fazer um emprestimo,esta aberto");
            }
            else
            {
                Console.WriteLine("O imprestimo esta fechado");
            }
            Console.ReadLine();
        }



    } 
}
    

    

