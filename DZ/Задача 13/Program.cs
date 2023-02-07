  int number = new Random().Next(1,10000000);
Console.WriteLine($"рандом число =>{number}");
    int sum = ngb(number);
    Console.WriteLine(sum);
   


static int ngb(int i)
{
 
    while (i >= 1000) i /= 10;
    int sum = i % 10;
    return sum;

    

}
