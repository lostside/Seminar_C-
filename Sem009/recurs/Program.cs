// написать рекурсивный метод для нахождения факториала числа

// fact(0) = 1
// fact(1) = 1
// fact(5) = 120
// fact(6) = 720
uint Fact(uint number){ // uint = Положительное целое число
    if(number <= 1) // сначала делаем услловие выхода из рекурсии
    { 
        return 1;
    }    
    else return number * Fact(number - 1); // вызываем метод внутри метода
}
Console.WriteLine(Fact(10));