using System;

namespace Mine.Helpers
{
    public static class DiceHelper
    {
        private static Random rnd = new Random();

        public static bool ForceRollsToNotRandom = false;

        public static int ForcedRandomValue = 1;

        /// <summary>
        /// Function to Roll the dice and get the results
        /// </summary>
        /// <param name="rolls"></param>
        /// <param name="dice"></param>
        /// <returns></returns>
        public static int RollDice(int rolls, int dice)
        {
            if (ForceRollsToNotRandom)
            {
                return rolls * ForcedRandomValue;
            }

            if (rolls < 1)
            {
                return 0;
            }

            if (dice < 1)
            {
                return 0;
            }

            var myReturn = 0;

            for (var i = 0; i < rolls; i++)
            {
                myReturn += rnd.Next(1, dice + 1);
            }

            return myReturn;
        }
    }
}

