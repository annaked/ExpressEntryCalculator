﻿namespace ExpressEntryCalculator.Core
{
    public static class SecondLanguagePointsCalculator
    {
        public static int SecondLangPointsCalculator(int clbPoints)
        {
            if (clbPoints >= 9)
            {
                return 6;
            }
            else if (clbPoints == 8 || clbPoints == 7)
            {
                return 3;
            }
            else if (clbPoints == 6 || clbPoints == 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
