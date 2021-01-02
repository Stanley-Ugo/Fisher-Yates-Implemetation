using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class FisherYatesShuffler
    {
        private static Random randomNumber = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                int j = GetRandomNumberAtPositionZeroAndI(i);
                objects.SwappValuesAtIndices(i, j);
            }
        }

        public static void DoFisherYatesAlternativeShuffle(this object[] objects)
        {
            for (int i = 0; i < objects.Length - 2; i++)
            {
                int j = GetRandomNumberAtPositionZeroAndI((objects.Length - i) - 1);
                objects.SwappValuesAtIndices(i, i + j);
            }
        }

        private static int GetRandomNumberAtPositionZeroAndI(int i)
        {
            return randomNumber.Next(i + 1);
        }
    }
}
