int nfix = 3;
int mfix = 5;
int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackermann(n - 1, 1);
    }
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
}

Console.Write(Ackermann(nfix, mfix));