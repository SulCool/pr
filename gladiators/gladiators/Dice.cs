using System;

namespace gladiators
{
    public class Dice
    {
        static Random r = new Random();

        public Random random { get { return r; } }
        public static int Roll(int x, int y)
        {
            int s = 0;
            for (int i = 0; i < x; i++)
                s += r.Next(y) + 1;
            return s;
        }

        public static int Next(int x, int y)
        {
            return r.Next(x, y);
        }

    }
}

