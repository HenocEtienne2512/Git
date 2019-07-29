using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListWithSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ListaDeCarro = new string[2, 3];

            var EscolhaOpcao = MenuInicial();

            while (true)
            {
                switch (EscolhaOpcao)
                {
                    case "1": { }; break; 
                    case "2": { }; break; 
                    case "3": { }; break; 
                    case "4": {
                            return;
                        };  

                }
                EscolhaOpcao = MenuInicial();
            }
        }
        public static string MenuInicial()
        {
            Console.WriteLine("***MENU PRINCIPAL***");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um registro existente.");
            Console.WriteLine("3 - Listar as informações.");
            Console.WriteLine("4 - Sair do sistema.\r\n");


            Console.WriteLine("Digite a opção desejada:");

            return Console.ReadLine();
        }
    }
}
