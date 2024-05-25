using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_01.UI
{
    public class Menu
    {
        bool canShowMenu = true;

        public void Show()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Buscar Cliente");
                Console.WriteLine("3. Apagar Cliente");
                Console.WriteLine("4. Encerrar");

                var option = Console.ReadLine();
                canShowMenu = SelectedOption(option);
                
            } while(canShowMenu);

            Environment.Exit(0);  
        }

        bool SelectedOption(string? option)
        {
            switch(option)
            {
                case "1":
                    Console.WriteLine("Cadastro de Cliente");
                    break;
                case "2":
                    Console.WriteLine("Busca de Cliente");
                    break;
                case "3":
                    Console.WriteLine("Apagação de Cliente");
                    break;
                 case "4":
                    Console.WriteLine("Encerrar");
                    return false;
                    
                default:
                    Console.WriteLine("Digite uma das opções válidas...");
                    break;
            }

            Thread.Sleep(500);
            return true;
        }
    }
}