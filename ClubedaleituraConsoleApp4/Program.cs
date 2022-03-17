using System;

namespace ClubedaleituraConsoleApp4
{
    internal class Revista
    {
        public static void Main(string[] args)
        {

            Menurevista menu = new Menurevista();
            ACaixa[] caixa = new ACaixa[100];
            CadastroDaRevista[] revista = new CadastroDaRevista[100];
            Emprestimodarevista[] emprestimodarevista = new Emprestimodarevista[100];
            Pessoa[] pessoa = new Pessoa[100];
            Objetos objetos = new Objetos();

            do
            {
                //menu
                switch (menu.Menuprincipal())
                {
                    case 1:
                        Console.WriteLine("digite a revista");
                       
                        int posicao = objetos.acharaposicaocorreta(revista);
                        revista[posicao] = new();
                        revista[posicao].revista(caixa);
                        break;

                    case 2:
                        posicao = objetos.acharaposicaocorreta(caixa);
                        caixa[posicao] = new();
                        caixa[posicao].registrandoacaixa();
                        break;

                    case 3:
                        posicao = objetos.acharaposicaocorreta(pessoa);
                        pessoa[posicao] = new();
                        pessoa[posicao].Registrar();
                        break;

                    case 4:
                        posicao = objetos.acharaposicaocorreta(emprestimodarevista);
                        emprestimodarevista[posicao] = new();
                        emprestimodarevista[posicao].Emprestimo(revista, pessoa);
                        break;

                    case 5:

                        posicao = objetos.acharaposicaocorreta(revista);
                        revista[posicao] = new();
                        revista[posicao].Registrorevista();

                        break;

                    case 6:
                        posicao = objetos.acharaposicaocorreta(pessoa);
                        pessoa[posicao] = new();
                        pessoa[posicao].MostraroRegistropessoa();

                        break;

                    case 7:
                        posicao = objetos.acharaposicaocorreta(caixa);
                        caixa[posicao] = new();
                        caixa[posicao].mostrarregistrocaixa();
                        break;

                    case 8:
                        posicao = objetos.acharaposicaocorreta(emprestimodarevista);
                        emprestimodarevista[posicao] = new();
                        emprestimodarevista[posicao].RegistrarEmprestimo();
                        break;





                }




            } while (true);

            static void Mostrar(dynamic[] variavel)
            {
                for (int i = 0; i < variavel.Length; i++)
                {
                    if (variavel[i] == null)
                        continue;
                    Console.WriteLine($"ID : {i}");
                    variavel[i].Mostrar();









                }
            }
        }
    }
}

