namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething1(bool b1, bool b2, bool b3, bool b4)
        {
            int result;

            if (!b1)
            {
                if (!b2)
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            result = 11;
                        }
                        else
                        {
                            result = 10;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            result = 5;
                        }
                        else
                        {
                            result = 6;
                        }
                    }
                }
                else
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            result = 8;
                        }
                        else
                        {
                            result = 9;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            result = 4;
                        }
                        else
                        {
                            result = 7;
                        }
                    }
                }
            }
            else
            {
                if (!b2)
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            result = 0;
                        }
                        else
                        {
                            result = 3;
                        }
                    }
                    else
                    {
                        result = 2;
                    }
                }
                else
                {
                    result = 1;
                }
            }

            return result;
        }

        public static int DoSomething2(bool b1, bool b2, bool b3, bool b4)
        {
            int result = 0;

            if (!b1)
            {
                if (!b2 && !b3)
                {
                    if (!b4)
                    {
                        result = 11;
                    }
                    else
                    {
                        result = 10;
                    }
                }
                else if (!b2 && b3)
                {
                    if (!b4)
                    {
                        result = 5;
                    }
                    else
                    {
                        result = 6;
                    }
                }
                else if (b2 && !b3)
                {
                    if (!b4)
                    {
                        result = 8;
                    }
                    else
                    {
                        result = 9;
                    }
                }
                else if (b2 && b3)
                {
                    if (!b4)
                    {
                        result = 4;
                    }
                    else
                    {
                        result = 7;
                    }
                }
            }
            else
            {
                if (!b2 && !b3)
                {
                    if (!b4)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = 3;
                    }
                }
                else if (!b2 && b3)
                {
                    result = 2;
                }
                else if (b2 && !b3)
                {
                    result = 1;
                }
                else
                {
                    result = 1;
                }
            }

            return result;
        }
    }
}
