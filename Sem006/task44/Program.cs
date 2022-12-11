// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n -2)

Console.WriteLine("Введите нужное количество первых цифр числа Фибоначчи");
int n = Convert.ToInt32(Console.ReadLine());

int[] fibb = new int[n];

fibb[0] = 0;
fibb[1] = 1;

for(int i = 2; i < n; i++)
{
    fibb[i] = fibb[i-1] + fibb[i-2];
    
}

Console.WriteLine($"[{string.Join(" ", fibb)}]");