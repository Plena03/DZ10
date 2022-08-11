//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Вводим любое трехзначное число:");
string? numberString = Console.ReadLine ();
var number=  int.Parse (numberString!);

//Random random = new Random();   //- для случайных чисел
//var randomNumber = random.Next(100, 1000); //- для случайных чисел
//Console.WriteLine(randomNumber);  // - для случайных чисел
//var number = (randomNumber % 100) / 10;  // - для случайных чисел

number = (number % 100) / 10;
Console.WriteLine("Выводим вторую цифру этого числа:");
Console.WriteLine(number);