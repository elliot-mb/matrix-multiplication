using System;

namespace matricies
{
    class Program
    {
        static void WriteMatrix(int[,] m) //writes a 2d array to console in matrix format
        {
            int rows = m.GetLength(0);
            int columns = m.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{m[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiply(int[,] m1, int[,] m2)
        {
            int m1rows = m1.GetLength(0),
                m1columns = m1.GetLength(1),
                m2rows = m2.GetLength(0),
                m2columns = m2.GetLength(1);

            int[,] output = new int[m1rows, m2columns];

            if (m1columns != m2rows) { return output; } //if theyre not multiplicable
            else
            {
                for(int i1 = 0; i1 < m1rows; i1++) //repeats for all rows in m1
                {
                    for(int j2 = 0; j2 < m2columns; j2++) //repeats for all columns in m2
                    {
                        int tempSum = 0;
                        for (int j1 = 0; j1 < m1columns; j1++) //repeats for all columns in m1
                        {
                            tempSum += m1[i1, j1] * m2[j1, j2]; //summing and multiplication 
                        }
                        output[i1, j2] = tempSum; //sets corrosponding value in output to row of m1, column of j2
                    }
                }
                return output;
            }
        }

        static void Main(string[] args)
        {
            //matricies as 2d arrays
            int[,] m1 = { { 0, -1, 1 }, 
                          { 0, -2, 1 } };
            int[,] m2 = { { 1, 0, 3 },
                          { 1, -1, -2 },
                          { 0, 2, -1 } };
            WriteMatrix(Multiply(m1, m2));
            Console.ReadLine();
        }
    }
}
