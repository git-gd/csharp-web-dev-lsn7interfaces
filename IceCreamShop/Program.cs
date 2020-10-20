using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            PrintFlavors(availableFlavors, "Flavors (Unsorted):");
            availableFlavors.Sort(new FlavorComparer());
            PrintFlavors(availableFlavors, "Flavors (Sorted by Name):");

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            PrintCones(availableCones, "Cones (Unsorted):");
            availableCones.Sort(new ConeComparer());
            PrintCones(availableCones, "Cones (Sorted by Cost):");

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            void PrintFlavors(List<Flavor> flavors, string txt)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(txt);
                Console.ResetColor();
                foreach (Flavor flavor in flavors) Console.WriteLine(flavor.Name);
                Console.WriteLine();
            }

            void PrintCones(List<Cone> cones, string txt)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(txt);
                Console.ResetColor();
                foreach (Cone cone in cones) Console.WriteLine($"{cone.Name}: {cone.Cost}");
                Console.WriteLine();
            }

            // BONUS: change FlavorComparer to sort by number allergens ... allergens is a list so Allergens.Count would be used in a way similar to ConeComparer
        }
    }
}
