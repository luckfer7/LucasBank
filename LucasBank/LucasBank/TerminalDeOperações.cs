using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasBank
{
    public class TerminalDeOperações
    {
        OperaçõesBancarias banco = new OperaçõesBancarias();

        public void IniciarPrograma()
        {
            

            while (true)
            {
                Menu();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        banco.ConsultarSaldo();
                    break;

                    case "2":
                        banco.DepositarDinheiro();
                    break;

                    case "3":
                        banco.SacarDinheiro();
                    break;
                }

            }
        }

        public void Menu ()
        {
            Console.WriteLine("\n===bank===\n");

            Console.WriteLine("Bem vindo, Lucas, a sua conta corrente: ");
            Console.WriteLine("Escolha a opçao correspondente");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinheiro");
            Console.WriteLine("3. Sacar dinheiro");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
