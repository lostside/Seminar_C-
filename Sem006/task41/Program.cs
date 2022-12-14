// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// break для остановки цикла


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
            if(i != input.Length - 1)
            {
                temp += input [i].ToString();
                i++;
            }
        else
        {
            temp += input [i].ToString();
            break;
        }
        
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
Console.WriteLine(string.Join(", ", numbers));
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");
