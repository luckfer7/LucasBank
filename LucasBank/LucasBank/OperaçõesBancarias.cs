using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasBank
{
    class OperaçõesBancarias
    {
        decimal saldo = 0;

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo atual: {saldo}");
        }

        public void DepositarDinheiro()
        {
            Console.WriteLine("Digite o valor que quer depositar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorDepositado) && valorDepositado > 0)
            {
                saldo = saldo + valorDepositado;
                Console.WriteLine("Valor foi depositado com sucesso!");
                Console.WriteLine($"Seu saldo atual: {saldo}");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("Informe o valor que deseja sacar: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorASacar) && valorASacar > 0)
            {
                if (valorASacar <= saldo)
                {
                    saldo = saldo - valorASacar;
                    Console.WriteLine("Espere um pouco estamos processando o seu pedido...");
                    Console.WriteLine("Valor sacado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Valor inválido ou é maior que o saldo disponível.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }
}
