  Console.Write("Digite um número, agora!: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar");
        }