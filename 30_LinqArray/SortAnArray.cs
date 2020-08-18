using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30_LinqArray
{
    public class SortAnArray
    {
        private static string[] ArrayOfTowns = new[]
            {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};

        public static void Sorter()
        {
            var query = from arrayOfTown in ArrayOfTowns
                orderby arrayOfTown.Length, arrayOfTown
                select arrayOfTown;

            var query1 = ArrayOfTowns.OrderBy(x =>x.Length).ThenBy(x => x);
            foreach (var town in query1)
            {
                Console.WriteLine(town);
            }
        }
    }
}
