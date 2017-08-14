using System;
using System.Collections.Generic;

namespace Testing3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution());
        }
        //https://pastebin.com/nrebVC6t
        private static int solution()
        {
            var suits = new string[] { "S", "C", "H", "D" };
            var cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };

            var array = new string[]
            {
                "AC", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "AC", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "AC", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH"
            };
            //var readLine = Console.ReadLine();
            //var input = Array.ConvertAll(array, s => s.Replace(" ", "").Replace("\"", "") );
            var input = array;

            var fullDesk = new HashSet<string>();
            var inputSet = new Dictionary<string, int>();

            for (int j = 0; j < cards.Length; j++)
            {
                for (int i = 0; i < suits.Length; i++)
                {
                    fullDesk.Add(cards[j] + suits[i]);
                }
            }

            foreach (var card in input)
            {
                if (inputSet.ContainsKey(card))
                    inputSet[card]++;
                else
                {
                    inputSet.Add(card, 1);
                }
            }

            var minCardNumber = int.MaxValue;
            foreach (var deskItem in fullDesk)
            {
                if (!inputSet.ContainsKey(deskItem))
                    return 0;

                minCardNumber = Math.Min(inputSet[deskItem], minCardNumber);
            }
            return minCardNumber;
        }
    }
}
