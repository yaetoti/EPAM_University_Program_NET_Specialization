﻿namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            int result;
            if (b)
            {
                if (i < -5 || i >= 5)
                {
                    result = i + 10;
                }
                else
                {
                    result = 10 - (i * i);
                }
            }
            else
            {
                if (i <= -7 || i > 4)
                {
                    result = i - 100;
                }
                else
                {
                    result = 10 - i;
                }
            }

            return result;
        }
    }
}
