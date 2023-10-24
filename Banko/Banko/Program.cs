//ID: 1
List<string> plade1Række1 = new List<string> {"20", "30", "43", "55", "70"};
List<string> plade1Række2 = new List<string> { "4", "14", "33", "44", "67"};
List<string> plade1Række3 = new List<string> {"29", "49", "68", "78", "87"};
//ID: 2
List<string> plade2Række1 = new List<string> {"24", "30", "40", "54", "64" };
List<string> plade2Række2 = new List<string> {"18", "27", "42", "65", "71" };
List<string> plade2Række3 = new List<string> {"7", "43", "57", "69", "89" };

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
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række3[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    //En variabel, som bliver brugt til at ændre i listerne
    Console.Write("Indsæt tallene her: ");
    trukketTal = Console.ReadLine();


    if (plade1Række1.Contains(trukketTal) || plade2Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        if (skiftTal != -1) 
            plade1Række1[skiftTal] = "X";
        skiftTal = plade2Række1.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal) || plade2Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række2[skiftTal] = "X";
        skiftTal = plade2Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal ) || plade2Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række3[skiftTal] = "X";
        skiftTal = plade2Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række3[skiftTal] = "X";
    }

    if (plade1Række1.All(x => x == "X") || plade1Række2.All(x => x == "X") || plade1Række3.All(x => x == "X"))
    {
        Console.WriteLine("Du har en fuld række på Plade: 1");
        fuldrække1 = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();
        Console.Clear();
    }

    else if (plade2Række1.All(x => x == "X") || plade2Række2.All(x => x == "X") || plade2Række3.All(x => x == "X"))
    {
        Console.WriteLine("Du har en fuld række på Plade: 2");
        fuldrække1 = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();        
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
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række3[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Indsæt tallene her: ");
    trukketTal = Console.ReadLine();

    if (plade1Række1.Contains(trukketTal) || plade2Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række1[skiftTal] = "X";
        skiftTal = plade2Række1.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal) || plade2Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række2[skiftTal] = "X";
        skiftTal = plade2Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal) || plade2Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række3[skiftTal] = "X";
        skiftTal = plade2Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række3[skiftTal] = "X";
    }

    if ((plade1Række1.All(x => x == "X") && plade1Række2.All(x => x == "X") ||
    (plade1Række2.All(x => x == "X") && plade1Række3.All(x => x == "X")) ||
    (plade1Række3.All(x => x == "X") && plade1Række1.All(x => x == "X"))))
    {
        Console.WriteLine("Du har to fulde rækker på Plade: 1");
        fuldrække2 = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();
        Console.Clear();
    }
    if ((plade2Række1.All(x => x == "X") && plade2Række2.All(x => x == "X") ||
    (plade2Række2.All(x => x == "X") && plade2Række3.All(x => x == "X")) ||
    (plade2Række3.All(x => x == "X") && plade2Række1.All(x => x == "X"))))
    {
        Console.WriteLine("Du har to fulde rækker på Plade: 2");
        fuldrække2 = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();
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
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række1[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.Write(plade2Række3[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Indsæt tallene her: ");
    trukketTal = Console.ReadLine();

    if (plade1Række1.Contains(trukketTal) || plade2Række1.Contains(trukketTal))
    {
        skiftTal = plade1Række1.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række1[skiftTal] = "X";
        skiftTal = plade2Række1.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række1[skiftTal] = "X";
    }
    else if (plade1Række2.Contains(trukketTal) || plade2Række2.Contains(trukketTal))
    {
        skiftTal = plade1Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række2[skiftTal] = "X";
        skiftTal = plade2Række2.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række2[skiftTal] = "X";
    }
    else if (plade1Række3.Contains(trukketTal) || plade2Række3.Contains(trukketTal))
    {
        skiftTal = plade1Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade1Række3[skiftTal] = "X";
        skiftTal = plade2Række3.IndexOf(trukketTal);
        if (skiftTal != -1)
            plade2Række3[skiftTal] = "X";
    }

    if (plade1Række1.All(x => x == "X") && plade1Række2.All(x => x == "X") && plade1Række3.All(x=> x == "X"))
    {
        Console.WriteLine("Du har fuld plade på Plade: 1");
        fuldPlade = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();
        Console.Clear();
    }
    else if (plade2Række1.All(x => x == "X") && plade2Række2.All(x => x == "X") && plade2Række3.All(x => x == "X"))
    {
        Console.WriteLine("Du har fuld plade på Plade: 2");
        fuldPlade = true;
        Console.WriteLine("Tryk enter for at fortsætte");
        Console.ReadLine();
        Console.Clear();
    }

    else
    {
        Console.Clear();
    }
} while (fuldPlade == false);
   