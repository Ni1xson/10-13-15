static uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(2, 3)); 
Console.WriteLine(Akk(0, 0)); 
Console.WriteLine(Akk(4, 5)); 
 
Console.ReadKey();