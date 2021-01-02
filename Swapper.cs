using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Swapper
    {
        public static void SwappValuesAtIndices(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
