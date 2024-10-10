using System;

class Program {

    static void Main() {

            //chci, aby ze program opakoval po stisku klavesy "a"

        string again = "a";
        while (again == "a") {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*******vzpis rady*********");
            Console.WriteLine("**************************");
            Console.WriteLine("*******Marie Borisjukova**");
            Console.WriteLine("************************/n/n");
            Console.WriteLine();

            // vstup do uzivatele - TO DO


            // Logika pro vypis rady - TO DO


            // opakovani programu 
            Console.WriteLine("pro opakovani programu stisknete klavesu a");
            again = Console.ReadLine();
        }


    }
}