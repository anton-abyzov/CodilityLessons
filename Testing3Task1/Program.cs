using System;

namespace Testing3Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var m = Convert.ToInt32(Console.ReadLine());

            var nStr = n.ToString();
            var mStr = m.ToString();
            var max = Math.Max(n, m);
            var length = max.ToString().Length;

            var carrySum = 0;
            var currentCarry = 0;
            for (int i = 0; i < length; i++)
            {
                var currentNDigit = 0;
                var currentMDigit = 0;
                if (i < nStr.Length)
                {
                    currentNDigit = int.Parse(nStr[nStr.Length - 1 - i].ToString());
                }
                if (i < mStr.Length)
                {
                    currentMDigit = int.Parse(mStr[mStr.Length - 1 - i].ToString());
                }

                var sum = currentNDigit + currentMDigit + currentCarry;
                if (sum >= 10)
                {
                    currentCarry = 1;
                    carrySum++;
                }
                else
                {
                    currentCarry = 0;
                }
            }


            Console.WriteLine(carrySum);
        }
    }
}
