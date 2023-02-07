Console.WriteLine("Введите трех значное число");
int rendomNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Конечное число =>{rendomNumber}");
int finishNumber = GetNumber(rendomNumber);
Console.WriteLine($"Конечное число =>{finishNumber}");

int GetNumber(int number)
{

int SecondNumber = number/10%10;


int result=SecondNumber/10+SecondNumber;
return result;
}



