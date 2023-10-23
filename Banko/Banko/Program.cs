List<string> plade1Række1 = new List<string> {"20", "30", "43", "55", "70"};
List<string> plade1Række2 = new List<string> { "4", "14", "33", "44", "67"};
List<string> plade1Række3 = new List<string> {"29", "49", "68", "78", "87"};

string trukketTal = "0";

for (int i = 0; i < 5; i++)
{
    Console.Write(plade1Række1[i]+ " ");
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.Write(plade1Række2[i]+ " ");
}
Console.WriteLine();
for (int i=0; i < 5; i++)
{
    Console.Write(plade1Række3[i] + " ");
}
Console.WriteLine();

trukketTal = Console.ReadLine();

if (plade1Række1.Contains(trukketTal))
{
    int skiftTal = plade1Række1.IndexOf(trukketTal);
    plade1Række1[skiftTal]="X";
    for (int i = 0; i < 5;i++)
    {
        Console.Write(plade1Række1[i] + " ");
    }
}

