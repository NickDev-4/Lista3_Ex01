Console.Clear();

double milhas, Km;

Console.Write("Digite uma distância em milhas: ");
milhas = double.Parse(Console.ReadLine());

Km = milhas * 1.609;

Console.WriteLine("");

Console.WriteLine("{0} milhas são {1}Km", milhas, Km);
