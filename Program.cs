using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoSelecao = -1;
            menu();
            do{
                opcaoSelecao = opcaoGeral();
            executarOpcao(opcaoSelecao);
            }while(opcaoSelecao != 0);

        }

        static void creditos()
        {
            Console.WriteLine(@"Criador: Wallace Tácio Teixeira
Site: https://wallacetacio.github.io/ProjetoFinal/");
        }

        static void executarOpcao(int opcao)
        {
            switch(opcao)
            {
                case 1:
                Soma();
                break;
                case 2:
                Subtracao();
                break;
                case 3:
                Mutiplicacao();
                break;
                case 4:
                Divisao();
                break;
                case 5:
                radiciacao();
                break;
                case 6:
                Exponenciacao();
                break;
                case 7:
                creditos();
                break;
                case 0:
                Console.WriteLine("Sair");
                break;                
                default:
                Console.WriteLine("Opcão inválida!");
                break;
            }
        }

        static void Exponenciacao()
        {
            double basResult;

            Console.Write("Digite a base: ");
            double bas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            double expn =  Convert.ToDouble(Console.ReadLine());

            basResult = Math.Pow(bas,expn);

            Console.WriteLine($"O resultado é {basResult}");
        }

        static void radiciacao()
        {
            Console.Write("Digite o radicando: ");
            double radicando = Convert.ToDouble(Console.ReadLine());

            double raizQuadrada = Math.Sqrt(radicando);

            Console.WriteLine($"O resultado é: {raizQuadrada}");
        }

        static void Divisao()
        {
            Console.Write("Digite o dividendo/numerador: ");
            decimal numerador = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o divisor/denominador: ");
            decimal denominador = Convert.ToDecimal(Console.ReadLine());

            decimal quociente = numerador / denominador;

            decimal resto = numerador % denominador;

            Console.WriteLine($"O quociente da divisão é: {quociente} e seu resto é: {resto}");
        }

        static void Mutiplicacao()
        {
            Console.Write("Digite a quantidade de números: ");
            int qnt = Convert.ToInt32(Console.ReadLine());
            int exb = 0;
            
            int mutiplicacao = 1;

            if (qnt <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERRO! ");
                Console.ResetColor();
                Console.WriteLine("Quantidade digitada deve ser maior que zero.");
            }
            else
            {

                while (exb < qnt)
                {
                    exb = exb + 1;

                    Console.Write($"Número #0{exb}: ");

                    int valor = Convert.ToInt32(Console.ReadLine());

                    mutiplicacao = valor * mutiplicacao;
                }
                Console.Write("Mutiplicação é igual a: ");
                Console.WriteLine(mutiplicacao);
            }
        
        }

        static void Subtracao()
        {
            Console.Write("Digite a quantidade de números: ");
            int qnt = Convert.ToInt32(Console.ReadLine());
            int exb = 0;
            
            int subtracao = 0;

            if (qnt <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERRO! ");
                Console.ResetColor();
                Console.WriteLine("Quantidade digitada deve ser maior que zero.");
            }
            else
            {

                while (exb < qnt)
                {
                    exb = exb + 1;

                    Console.Write($"Número #0{exb}: ");

                    int valor = Convert.ToInt32(Console.ReadLine());

                    subtracao = Math.Abs(subtracao) - Math.Abs(valor);
                }
                Console.Write("Subtração é igual a: ");
                Console.WriteLine(subtracao);
            }
        
        }
        static void Soma()
        {
            Console.Write("Digite a quantidade de números: ");
            int qnt = Convert.ToInt32(Console.ReadLine());
            int exb = 0;
            int valor;
            int soma = 0;

            if (qnt <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERRO! ");
                Console.ResetColor();
                Console.WriteLine("Quantidade digitada deve ser maior que zero.");
            }
            else
            {

                while (exb < qnt)
                {
                    exb = exb + 1;

                    Console.Write($"Número #0{exb}: ");

                    valor = Convert.ToInt32(Console.ReadLine());

                    soma = soma + valor;
                }
                Console.Write("Soma é igual a: ");
                Console.WriteLine(soma);
            }
        
        }

        static void menu()
        {
                string menu = @"
            *===================*
            | Menu de Opções    |
            *===================*
            | 1 - Soma          |
            | 2 - Subtração     |
            | 3 - Multiplicação |
            | 4 - Divisão       |
            | 5 - Radiciação    |
            | 6 - Exponenciação |
            | 7 - Créditos      |
            | 0 - Sair          |
            *===================*";
            Console.WriteLine(menu);
        }

        static int opcaoGeral()
        {
            
            Console.Write("Digite o número referente a opção: ");
            string opcaoDigitada = Console.ReadLine();
            int number;
            bool itsNumber = Int32.TryParse(opcaoDigitada, out number);
            if(itsNumber)
            {
                return number;
            }
            else
            {
                return -1;
            }
        }
    }
}
