using MatekLib;

List<Matek> megoldások = new();

Console.Write("Hanyas számértékig keresse az értéket:");
int keresesErtek = int.Parse(Console.ReadLine());


for (int i = 0; i < keresesErtek; i++)
{
    for (int j = 0; j < keresesErtek; j++)
    {
        for (int k = 0; k < keresesErtek; k++)
        {
            Matek jelenlegiMatek = new(i, j, k);
            if(jelenlegiMatek.HelyesMegoldás == true)
            {
                if (i != 0 && j != 0 && k != 0)
                {
                    megoldások.Add(jelenlegiMatek);
                }
            }
        }
    }
}

Console.WriteLine("Helyes megoldások:");

foreach (var megoldas in megoldások)
{
    Console.WriteLine(megoldas.ToString()); 
}
Console.WriteLine();
Console.WriteLine($"Helyes megoldások száma: {megoldások.Count()}");