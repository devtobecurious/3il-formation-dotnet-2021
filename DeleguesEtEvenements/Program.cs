using static DeleguesEtEvenements.Delegates;

Log("Hello");
Compute(Log, 1, 2, 3, 4, 5, 8, 122);
Compute(Log2, 1, 2, 3, 4, 5, 8, 122);


int Compute(DelegueDeLog logger, params int[] args)
{
    int result = 0;

    for (int i = 0; i < args.Length; i++) // TODO 3 : Dans une function
    {
        // Log(args[i].ToString(), ConsoleColor.Green);// TODO 1: Concaténer avant d'afficher
        logger(args[i].ToString(), ConsoleColor.Green);
        result += args[i];  
    }

    return result;
}

// TODO 2: Une classe de log 
// TODO 2.1: Mettre la classe de log dans une bibliothèque
void Log(string message, ConsoleColor currentColor = ConsoleColor.White)
{
    Console.ForegroundColor = currentColor;
    Console.WriteLine(message);
}

void Log2(string message, ConsoleColor currentColor = ConsoleColor.White)
{
    Console.ForegroundColor = currentColor;
    Console.WriteLine(message.ToUpper());
}
