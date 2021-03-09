
//Programa Salão de Beleza
//Classe principal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> lst = new List<Cliente>();    //Declara que haverá uma lista de clientes.
           // List<Agendamento> lst1 = new List<Agendamento>();


            Console.WriteLine("");



            bool continua = true;                       //Enquanto true roda o que está dentro do while.

            while (continua)
            {
                Console.WriteLine("Qual operação deseja realizar? C - Cadastrar ou A - Agendamento de Serviço");

                var resposta = Console.ReadLine();      //Guarda tudo o que for escrito no teclado na variável resposta.

                if (resposta.ToUpper() == "C")          //Testa se a resposta foi letra (C ou c).
                {
                    Console.WriteLine("Nome:");
                    string nomedoCliente = (Console.ReadLine());

                    Console.WriteLine("Telefone:");
                    int numeroTelefone = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Email:");
                    string emaildoCliente = (Console.ReadLine());



                    Cliente temp = new Cliente();               //Para evitar que sejam sobrepostos os dados de cada cliente
                    temp.nomedoCliente = nomedoCliente;         //foram criadas variáveis do tipo new, ou seja, para cada cliente
                                                                //uma posição na memória.
                    Cliente temp1 = new Cliente();
                    temp1.numeroTelefone = numeroTelefone;

                    Cliente temp2 = new Cliente();
                    temp2.emaildoCliente = emaildoCliente;

                    lst.Add(temp);                              //Adiciona as 3 variáveis do tipo new à lista do novo cliente.
                }


                if (resposta.ToUpper() == "A")
                {
/*
                    Console.WriteLine("Nome:");
                    string nomesdoCliente = (Console.ReadLine());


                    Agendamento temp4 = new Agendamento();               //Para evitar que sejam sobrepostos os dados de cada cliente
                    temp4.nomesdoCliente = nomesdoCliente;




                    /* // List<Agendamento> lst1 = new List<Agendamento>();


                    Console.WriteLine("Qual serviço? 1- Corte Cabelo 2- Manicure ");
                    int tipoServiço = Convert.ToInt32(Console.ReadLine());


                    Agendamento temp4 = new Agendamento();               //Para evitar que sejam sobrepostos os dados de cada cliente
                    temp4.tipoServiço = tipoServiço;
                    
*/





                    //lst1.Add(temp4);


                }


                
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                Console.WriteLine("Sair: S/N");
                continua = Console.ReadLine() != "S";
            }

        }
    }
}


