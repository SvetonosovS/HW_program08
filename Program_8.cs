Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
int i = 1;
bool Not = true;
Console.Write(userNumber + " -> ");

while (i <= userNumber)
{
if (i % 2 != 1)
    Console.Write(i + ", ");
    Not = false;
 i++;
}
if (Not)
{
    Console.WriteLine("Нет чётных чисел!");
}