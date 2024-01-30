do
{
    int resultado = 0;

    Console.WriteLine("Escolha qual calculadora você irá utilizar: Calculadora Normal ou Calculadora de Ano-Bissexto (1/2)");
    double tipoCalculadora = LerTipoCalculadora();

    static double LerTipoCalculadora()
    {
        double calculadora;
        while (!double.TryParse(Console.ReadLine(), out calculadora) || calculadora < 1 || calculadora > 2)
        {
            Console.WriteLine("Operação inválida. Por favor, digite uma Operação válida 1 ou 2: ");
        }
        return calculadora;
    }

    if (tipoCalculadora == 1)
    {
        Console.WriteLine("Informe a Operação desejada: '1' para soma; '2' para subtração; '3' para multiplicação; '4' para divisão;");
        double operacao = LerOperacao();

        Console.WriteLine("Informe dois números para a operação.\nNúmero 1: ");
        string num1 = Console.ReadLine();

        Console.WriteLine("Número 2: ");
        string num2 = Console.ReadLine();

        if (operacao == 1)
        {
            resultado = Int32.Parse(num1) + Int32.Parse(num2);
            Console.WriteLine("Resultado: {0} {1} {2} = {3}", num1, "+", num2, resultado);
        }

        else if (operacao == 2)
        {
            resultado = Int32.Parse(num1) - Int32.Parse(num2);
            Console.WriteLine("Resultado: {0} {1} {2} = {3}", num1, "-", num2, resultado);
        }

        else if (operacao == 3)
        {
            resultado = Int32.Parse(num1) * Int32.Parse(num2);
            Console.WriteLine("Resultado: {0} {1} {2} = {3}", num1, "*", num2, resultado);
        }

        else
        {
            if (Int32.Parse(num2) != 0)
            {
                resultado = Int32.Parse(num1) / Int32.Parse(num2);
                Console.WriteLine("Resultado: {0} {1} {2} = {3}", num1, "/", num2, resultado);
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero.");
                continue;
            }
        }

        static double LerOperacao()
        {
            double operacao;
            while (!double.TryParse(Console.ReadLine(), out operacao) || operacao < 1 || operacao > 4)
            {
                Console.WriteLine("Operação inválida. Por favor, digite uma Operação válida entre 1 e 4: ");
            }
            return operacao;
        }
    }

    else
    {
        Console.WriteLine("Escreva um ano para saber se é bissexto 'YYYY': ");
        string ano = Console.ReadLine();

        if (Int32.Parse(ano) % 4 == 0 || (Int32.Parse(ano) % 400 == 0 && Int32.Parse(ano) % 100 != 0))
        {
            Console.WriteLine("O ano é bissexto.");
        }
        else
        {
            Console.WriteLine("O ano não é bissexto");
        }
    }

    Console.WriteLine("Deseja reiniciar o programa? (S/N)");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() != "S")
    {
        Console.WriteLine("Encerrando o programa...");
        break;
    }

    Console.Clear();

} while (true);