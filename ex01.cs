using System;


 void PrintNat(int n)
{
    if (n > 0)
    {
        Console.Write($" {n} ");
        PrintNat(n - 1);
    }
}
PrintNat(5);