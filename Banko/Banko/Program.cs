using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
class Program
{



    //ID: 1
    static List<string> plade1Række1 = new List<string> { "20", "30", "43", "55", "70" };
    static List<string> plade1Række2 = new List<string> { "4", "14", "33", "44", "67" };
    static List<string> plade1Række3 = new List<string> { "29", "49", "68", "78", "87" };
    //ID: 2
    static List<string> plade2Række1 = new List<string> { "24", "30", "40", "54", "64" };
    static List<string> plade2Række2 = new List<string> { "18", "27", "42", "65", "71" };
    static List<string> plade2Række3 = new List<string> { "7", "43", "57", "69", "89" };

    static string trukketTal = "0";
    static int skiftTal;
    static bool fuldrække1 = false;
    static bool fuldrække2 = false;
    static bool fuldPlade = false;

    static void Main()
    {


        do
        {
            // Dette skriver pladerne ud
            Console.WriteLine("Plade 1");
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
            Console.WriteLine("Plade 2");
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

            //En variabel, som bliver brugt til at interagere med listerne
            Console.Write("Indsæt tal her: ");
            trukketTal = Console.ReadLine();

            if (Convert.ToInt32(trukketTal) >= 91 || Convert.ToInt32(trukketTal) < 1)
            {
                Console.WriteLine("Det er et ugyldigt tal");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Række1Update(plade1Række1);
                Række1Update(plade2Række1);
                Række2Update(plade1Række2);
                Række2Update(plade2Række2);
                Række3Update(plade1Række3);
                Række3Update(plade2Række3);
                Thread.Sleep(1000);

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
            }

        } while (fuldrække1 == false);

        do
        {
            Console.WriteLine("Plade 1");
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
            Console.WriteLine("Plade 2");
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

            Række1Update(plade1Række1);
            Række1Update(plade2Række1);
            Række2Update(plade1Række2);
            Række2Update(plade2Række2);
            Række3Update(plade1Række3);
            Række3Update(plade2Række3);
            Thread.Sleep(1000);

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
            Console.WriteLine("Plade 1");
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
            Console.WriteLine("Plade 2");
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

            Række1Update(plade1Række1);
            Række1Update(plade2Række1);
            Række2Update(plade1Række2);
            Række2Update(plade2Række2);
            Række3Update(plade1Række3);
            Række3Update(plade2Række3);
            Thread.Sleep(1000);

            if (plade1Række1.All(x => x == "X") && plade1Række2.All(x => x == "X") && plade1Række3.All(x => x == "X"))
            {
                Console.WriteLine("Du har fuld plade på Plade: 1");
                fuldPlade = true;
                Console.WriteLine();
                Console.WriteLine("Du har vundet!");
                Console.WriteLine("Tryk enter for at fortsætte");
                Console.ReadLine();
                Console.Clear();
            }
            else if (plade2Række1.All(x => x == "X") && plade2Række2.All(x => x == "X") && plade2Række3.All(x => x == "X"))
            {
                Console.WriteLine("Du har fuld plade på Plade: 2");
                fuldPlade = true;
                Console.WriteLine();
                Console.WriteLine("Du har vundet!");
                Console.WriteLine("Tryk enter for at afslutte");
                Console.ReadLine();
                Console.Clear();
            }

            else
            {
                Console.Clear();
            }
        } while (fuldPlade == false);


        static void Række1Update(List<string> plade)
        {
            if (plade1Række1.Contains(trukketTal) || plade2Række1.Contains(trukketTal))
            {
                skiftTal = plade1Række1.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade1Række1[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 1");
                }
                skiftTal = plade2Række1.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade2Række1[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 2");
                }
            }
        }
        static void Række2Update(List<string> plade)
        {
            if (plade1Række2.Contains(trukketTal) || plade2Række2.Contains(trukketTal))
            {
                skiftTal = plade1Række2.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade1Række2[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 1");
                }
                skiftTal = plade2Række2.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade2Række2[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 2");
                }
            }
        }
        static void Række3Update(List<string> plade)
        {
            if (plade1Række3.Contains(trukketTal) || plade2Række3.Contains(trukketTal))
            {
                skiftTal = plade1Række3.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade1Række3[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 1");
                }
                skiftTal = plade2Række3.IndexOf(trukketTal);
                if (skiftTal != -1)
                {
                    plade2Række3[skiftTal] = "X";
                    Console.WriteLine(trukketTal + " er på Plade 2");
                }
            }
        }       
    }
}