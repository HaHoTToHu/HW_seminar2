/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

// Console.WriteLine("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Tripopotam()
// {
// if (number >= 100 && number < 1000)
//     Console.WriteLine((number % 100) / 10);
// else
//     Console.WriteLine("Введите правильное число!");
// }

// Console.Write("Вторая цифра этого числа: ");
// Tripopotam();



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void ThirdNumber(int number)
// {
//     while(number > 999)
//     {
//         number = number/10;
//     }
//     if(number < 999 & number > 100)
//     {
//         number %= 10;
//         Console.WriteLine(number);
//     }
//     else if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
    
// }

// ThirdNumber(number);


/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

// Console.WriteLine("Введите цифру от 1 до 7: ");
// int day = Convert.ToInt32(Console.ReadLine());

// void DayOfWeek (int day)
// {
//     if(day == 6 || day == 7) Console.WriteLine("Поздравляшки! Это выходной!");

//     else if (day > 7 || day < 1) Console.WriteLine("Внимательнее! Введите число в указанном диапазоне.");
//     else Console.WriteLine("К сожалению, это будний день..");


// }

// DayOfWeek(day);