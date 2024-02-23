int num;

do
{
    Console.Write("Digite um número (0 para sair): ");
    string? numTemp = Console.ReadLine();

    if (!int.TryParse(numTemp!, out num))
    {
        Console.WriteLine("Por favor, digite um número válido!");
        continue;
    }

    if (num <= 0)
    {
        break;
    }

    bool isPrime = true;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime && num > 1)
    {
        Console.WriteLine($"O número {num} é primo!");
    }
    else
    {
        Console.WriteLine($"O número {num} não é primo!");
    }

} while (true);
