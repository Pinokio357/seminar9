using System;
int m = 4;
int n = 8;

int  Summa(int m, int n)  
   {
    if (n == m) return m;
    else  
        return n + Summa(m, n -1);
}
Console.WriteLine(Summa(m, n));
