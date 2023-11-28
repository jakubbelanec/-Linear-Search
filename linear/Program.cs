int[] vyskaLidi = new int[50];
Random random = new Random();
for (int i = 0; i < vyskaLidi.Length; i++)
{
    vyskaLidi[i] = random.Next(40, 220);
}

Console.WriteLine("Všechny výšky:");
foreach (var vyska in vyskaLidi)
{
    Console.Write(vyska + " ");
}
Console.WriteLine();


Console.Write("Chci najít člověka s výškou: ");
int hledanaVyska = Convert.ToInt32(Console.ReadLine());

bool nalezeno = false;
for (int i = 0; i < vyskaLidi.Length; i++)
{
    if (vyskaLidi[i] == hledanaVyska)
    {
        nalezeno = true;
        break;
    }
}

if (nalezeno)
{
    Console.WriteLine($"Hodnota {hledanaVyska} byla nalezena.");
}
else
{
    Console.WriteLine($"Hodnota {hledanaVyska} nebyla nalezena.");
}
Console.ReadLine();