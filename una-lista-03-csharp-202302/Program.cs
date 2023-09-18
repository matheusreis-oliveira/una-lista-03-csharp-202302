class Program
{
    static void Main()
    {
        while (Menu())
        {
            try
            {
                Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro não tratado, pressione enter para retornar ao menu.");
                Console.ReadLine();
            }
        }
    }

    static bool Menu()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das opções abaixo:");
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"- {i}. Atividade {i}");
            }
            Console.WriteLine("- 0. Sair\n");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Atividade01();
                    break;
                case "2":
                    Atividade02();
                    break;
                case "3":
                    Atividade03();
                    break;
                case "4":
                    Atividade04();
                    break;
                case "5":
                    Atividade05();
                    break;
                case "6":
                    Atividade06();
                    break;
                case "0":
                    return false;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
                    Console.ReadLine();
                    break;
            }

            Console.Clear();
        }
    }

    private static void Atividade01()
    {
        Console.WriteLine("Executando Atividade 1...");

        double num1 = ReadDouble("Informe o primeiro número: ");
        double num2 = ReadDouble("Informe o segundo número: ");
        double num3 = ReadDouble("Informe o terceiro número: ");

        double maior = Math.Max(num1, Math.Max(num2, num3));
        double menor = Math.Min(num1, Math.Min(num2, num3));
        double media = (num1 + num2 + num3) / 3;

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"A média aritmética é: {media}");
        Pause();
    }

    private static void Atividade02()
    {
        Console.WriteLine("Executando Atividade 2...");

        double valorCompra = ReadDouble("Informe o valor da compra: R$ ");
        double valorPago = ReadDouble("Informe o valor pago: R$ ");

        if (valorPago < valorCompra)
        {
            Console.WriteLine("A quantia paga é insuficiente para realizar a compra.");
            Pause();
            return;
        }

        double troco = valorPago - valorCompra;
        int[] notas = { 50, 20, 10, 5, 2, 1 };
        int[] quantidadeNotas = new int[6];

        for (int i = 0; i < notas.Length; i++)
        {
            while (troco >= notas[i])
            {
                troco -= notas[i];
                quantidadeNotas[i]++;
            }
        }

        Console.WriteLine($"Troco: R$ {valorPago - valorCompra}");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Notas de R$ {notas[i]},00: {quantidadeNotas[i]}");
        }
        Pause();
    }

    private static void Atividade03()
    {
        Console.WriteLine("Executando Atividade 3...");

        double a = ReadDouble("Informe o coeficiente a: ");
        double b = ReadDouble("Informe o coeficiente b: ");
        double c = ReadDouble("Informe o coeficiente c: ");

        if (a == 0 && b == 0)
        {
            if (c != 0)
            {
                Console.WriteLine("Coeficientes informados incorretamente.");
            }
            else
            {
                Console.WriteLine("Esta é uma equação degenerada.");
            }
        }
        else if (a == 0)
        {
            Console.WriteLine("Essa é uma equação de primeiro grau.");
            double raiz = -c / b;
            Console.WriteLine($"Raiz: {raiz}");
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Esta equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Esta equação possui duas raízes reais iguais.");
                double raiz = -b / (2 * a);
                Console.WriteLine($"Raízes: {raiz}");
            }
            else
            {
                Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Raízes: {raiz1} e {raiz2}");
            }
        }
        Pause();
    }

    private static void Atividade04()
    {
        Console.WriteLine("Executando Atividade 4...");

        int operacao = ReadInt("Informe o indicador de operação (1, 2 ou 3): ");
        double raio = ReadDouble("Informe o raio: ");

        double pi = 3.141592;

        switch (operacao)
        {
            case 1:
                double perimetro = 2 * pi * raio;
                Console.WriteLine($"Perímetro do círculo: {perimetro}");
                break;
            case 2:
                double area = pi * raio * raio;
                Console.WriteLine($"Área do círculo: {area}");
                break;
            case 3:
                double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);
                Console.WriteLine($"Volume da esfera: {volume}");
                break;
            default:
                Console.WriteLine("Código da operação é inválido.");
                break;
        }
        Pause();
    }

    private static void Atividade05()
    {
        Console.WriteLine("Executando Atividade 5...");

        double numero1 = ReadDouble("Informe o primeiro número: ");
        double numero2 = ReadDouble("Informe o segundo número: ");
        Console.Write("Informe o símbolo da operação (+, -, *, /, ^): ");
        string operacao = Console.ReadLine();

        double resultado;
        switch (operacao)
        {
            case "+":
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "-":
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "*":
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado: {resultado}");
                break;
            case "/":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                }
                break;
            case "^":
                resultado = Math.Pow(numero1, numero2);
                Console.WriteLine($"Resultado: {resultado}");
                break;
            default:
                Console.WriteLine("Símbolo da operação é inválido.");
                break;
        }
        Pause();
    }

    private static void Atividade06()
    {
        Console.WriteLine("Executando Atividade 6...");

        int num1 = ReadInt("Informe o primeiro número inteiro: ");
        int num2 = ReadInt("Informe o segundo número inteiro: ");

        int menor = Math.Min(num1, num2);
        int maior = Math.Max(num1, num2);

        Random rand = new Random();
        int numeroAleatorio = rand.Next(menor, maior + 1);
        Console.WriteLine($"Número sorteado: {numeroAleatorio}");
        Console.WriteLine(numeroAleatorio % 2 == 0 ? "O número é par." : "O número é ímpar.");
        Pause();
    }

    private static void Pause()
    {
        Console.WriteLine("Pressione Enter para retornar ao menu.");
        Console.ReadLine();
    }

    private static double ReadDouble(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }

    private static int ReadInt(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
}