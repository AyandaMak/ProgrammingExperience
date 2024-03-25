using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExperience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Refer to the Test Cases folder for test data input and expected output
            //FavoriteSinger();  -- Uncomment when running/debugging
            //MonkAndRotation(); -- Uncomment when running/debugging
        }
        public static void FavoriteSinger()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] playlist = Console.ReadLine().Split(' ');
            List<string> favouritelist = new List<string>();
            int highest = 0;
            int favourite = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                if (!favouritelist.Contains(playlist[i]))
                {
                    favouritelist.Add(playlist[i]);
                    for (int j = 0; j < n; j++)
                    {
                        if (playlist[i] == playlist[j])
                            count++;
                    }
                }
                if (count == highest)
                {
                    highest = count;
                    favourite++;
                }
                else if (count > highest)
                {
                    favourite = 0;
                    highest = count;
                    favourite++;
                }
            }
            if (highest == 1)
            {
                highest = n;
            }
            if (favourite > highest)
            {
                highest = favourite;
            }
            Console.WriteLine(highest);
            Console.ReadLine();
        }
        public static void MonkAndRotation()
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < testCases; t++)
            {
                string[] numOfElementandRotation = Console.ReadLine().Split(' ');
                int k = Convert.ToInt32(numOfElementandRotation[1]);
                string[] array = Console.ReadLine().Split(' ');
                do
                {
                    string lastval = array[Convert.ToInt32(numOfElementandRotation[0]) - 1];
                    for (int i = Convert.ToInt32(numOfElementandRotation[0]) - 1; i > 0; i--)
                    {

                        array[i] = array[i - 1];
                    }

                    array[0] = lastval;
                    k--;
                }
                while (k > 0);
                Console.WriteLine(string.Join(" ", array));
            }
            Console.ReadLine();
        }
    }
}
