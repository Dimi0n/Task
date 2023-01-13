Console.WriteLine("введите целое число:");
int number1 = Convert.ToInt32(Console.ReadLine()); //25 
int number2 = Convert.ToInt32(Console.ReadLine()); // 2
int square = number2 * number2;
if (number1 == square )
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}
