// написать рекурсивный метод для нахождения факториала числа

// fact(0) = 1
// fact(1) = 1
// fact(5) = 120
// fact(6) = 720
uint Fact(uint number){ // uint = Положительное целое число
    if(number == 0 || number == 1) // сначала делаем выход из рекурсии
    return 1;
    return number * Fact(number -1);
}
Console.WriteLine(Fact(6));