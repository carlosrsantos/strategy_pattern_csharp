using Calculator.Context;
using Calculator.Strategy;
using Strategy;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            
            string escolha = Console.ReadLine();

            if (escolha == "5")
            {
                Console.WriteLine("Encerrando o programa...");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                IOperation operation = escolha switch
                {
                    "1" => new AdditionOperation(),
                    "2" => new SubtractionOperation(),
                    "3" => new MultiplicationOperation(),
                    "4" => new DivisionOperation(),
                    _ => throw new InvalidOperationException("Opção inválida. Tente novamente.")
                };
                var calculator = new CalculatorContext(operation);
                Console.WriteLine($"\nResultado: {calculator.Calculate(num1, num2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}