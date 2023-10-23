//ID: 1
List<string> plade1Række1 = new List<string> {"20", "30", "43", "55", "70"};
List<string> plade1Række2 = new List<string> { "4", "14", "33", "44", "67"};
List<string> plade1Række3 = new List<string> {"29", "49", "68", "78", "87"};


string trukketTal = "0";
int skiftTal;
bool fuldrække1 = false;
bool fuldrække2 = false;
bool fuldPlade = false;

do
{
    // Dette skriver pladerne ud
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række3[i] + " ");
    }
    Console.WriteLine();

    //En variabel, som bliver brugt til at ændre i listerne
    trukketTal = Console.ReadLine();


    if (plade1Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        plade1Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        plade1Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        plade1Række3[skiftTal] = "X";
    }

    if (plade1Række1.All(x => x == "X") || plade1Række2.All(x => x == "X") || plade1Række3.All(x => x == "X"))
    {
        Console.WriteLine("Du har en fuld række");
        fuldrække1 = true;
        Console.ReadLine();
        Console.WriteLine("Tryk for at fortsætte");
        Console.Clear();
    }

    else 
    {
        Console.Clear(); 
    }
} while (fuldrække1 == false);




do
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række3[i] + " ");
    }
    Console.WriteLine();

    trukketTal = Console.ReadLine();

    if (plade1Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        plade1Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        plade1Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        plade1Række3[skiftTal] = "X";
    }

    if ((plade1Række1.All(x => x == "X") && plade1Række2.All(x => x == "X")) ||
    (plade1Række2.All(x => x == "X") && plade1Række3.All(x => x == "X")) ||
    (plade1Række3.All(x => x == "X") && plade1Række1.All(x => x == "X")))
    {
        Console.WriteLine("Du har to fulde rækker");
        fuldrække2 = true;
        Console.ReadLine();
        Console.WriteLine("Tryk for at fortsætte");
        Console.Clear();
    }


    else
    {
        Console.Clear();
    }
} while (fuldrække2 == false);



do
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade1Række3[i] + " ");
    }
    Console.WriteLine();

    trukketTal = Console.ReadLine();

    if (plade1Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        plade1Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        plade1Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        plade1Række3[skiftTal] = "X";
    }

    if (plade1Række1.All(x => x == "X") && plade1Række2.All(x => x == "X") && plade1Række3.All(x=> x == "X"))
    {
        Console.WriteLine("Du har fuld plade");
        fuldPlade = true;
        Console.ReadLine();
        Console.WriteLine("Tryk for at fortsætte");
        Console.Clear();
    }

    else
    {
        Console.Clear();
    }
} while (fuldPlade == false);
