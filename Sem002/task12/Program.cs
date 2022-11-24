// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

if (digit1 % digit2 == 0)
{
    Console.WriteLine("Они кратны");

}
else
{
    Console.WriteLine($"Остаток от деления = {digit1 % digit2}");
}