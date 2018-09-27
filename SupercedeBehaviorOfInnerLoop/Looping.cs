using System;
using System.Collections.Generic;
using System.Linq;


namespace SupercedeBehaviorOfInnerLoop
{
    public static class Looping
    {
        static readonly int[] OriginalList = new int[] { 1, 2, 3, 4, 5 };
                
        public static List<int> funcTransform(int multiplier)
        {
            List<int> NewSet = new List<int>(OriginalList);
            NewSet = NewSet.Select(item => item * multiplier).ToList();
            return NewSet;
        }

        public static List<int> funcTransformMaxMuliplierOnly(int[] PossibleMultipliers)
        {
            int multiplier = PossibleMultipliers.Max(m => m);
            List<int> NewSet = new List<int>(OriginalList);
            NewSet = NewSet.Select(item => item * multiplier).ToList();
            return NewSet;
        }
    }
}
