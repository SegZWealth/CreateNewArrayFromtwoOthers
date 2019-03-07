using System;


namespace interleave2arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[] { "1", "2", "3" };
            string[] B = new string[] { "A", "B", "C" };
            int lengthA = A.Length;
            int lengthB = B.Length;
            string[] c = new string[lengthA + lengthB];

            int counterA = 0;
            int counterB = 0;

            while (c.Length != (counterA + counterB))
            {
                if (A.Length - 1 >= counterA)
                {
                    c[counterA + counterB] = A[counterA];
                    counterA++;
                }

                if (B.Length - 1 >= counterB)
                {
                    c[counterA + counterB] = B[counterB];
                }
                counterB++;
            }

            foreach (var item in c)
            {
                Console.Write(item + ",");
            }


            Console.ReadLine();

        }

       
    }
}