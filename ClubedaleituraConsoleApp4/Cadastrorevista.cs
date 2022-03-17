using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaleituraConsoleApp4
{
    
    
        internal class CadastroDaRevista
        {


            public int numerodaEdicao;
            public string tipodeColecao;
            public double anodaRevista;
            public int numeroCaixa, numerocaixaEditar;
            
           
            public bool revistaDisponivel = true;
            public int Adcionarrevistanacaixa;

            public ACaixa caixadaRevista;

            public  void revista (ACaixa[] caixa)
            {
                
                Console.WriteLine("Qual a coleção da revista = ");
                string tipodeColecao = Convert.ToString(Console.ReadLine());


                Console.WriteLine("Qual o ano da revista = ");
                int  anodaRevista = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o numero da edicao da revista = ");
                 int numerodaEdicao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o  numero da caixa que deseja guardar? = ");

                for (int i = 0; i < caixa.Length; i++)
                {
                    if (caixa[i] == null)
                        continue;
                    Console.Write($"caixa: {caixa[i].cor}|  " +
                        $" {caixa[i].numerodaCaixa} |  {caixa[i].etiqueta} " +
                        $"| o numero da caixa eh {i}");

                }
                Adcionarrevistanacaixa = Convert.ToInt32(Console.ReadLine());
                caixadaRevista = caixa[Adcionarrevistanacaixa];
                Console.WriteLine("sua revista foi cadastrada com sucesso!");

            }
           
            public void Registrorevista ()
            {
               
                  
                        Console.WriteLine("Sua coleção de revista" + tipodeColecao);
                        Console.WriteLine("O ano da revista" + anodaRevista);
                        Console.WriteLine("Ano da edicao" + numerodaEdicao);
                    
              
                Console.ReadLine();       
                       

            }
           



            

           
                
            

        }
        
    


}

