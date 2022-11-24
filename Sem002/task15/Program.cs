// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной, отдыхай!");
}
else

    if (day < 6 )
    {
        Console.WriteLine("Жди выходных, они близко");
    }

// else

//     if (day == 3){
//             Console.WriteLine("Среда - маленькая пятница)");
//         }
   
// else
//    if (day == 5)
//     {
//         Console.WriteLine("Пяятниицаа");
//     }

