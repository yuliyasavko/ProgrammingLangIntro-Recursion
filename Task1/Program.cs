int m = 5;
int n = 89;
void PrintNaturals (int k, int maxk)
{
    if (k < maxk + 1)
    {
        Console.Write($"{k} ");
        PrintNaturals(k + 1, maxk);
    }

}
PrintNaturals(m, n);