// ************************************************************************************************
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// Console.Clear();
// int num = new Random().Next(10, 100);
// System.Console.WriteLine($"Было сгенерировано случайное числов {num}");  // System.Console.WriteLine("Было сгенерировано случайное числов " + num);
// int x1 = num / 10;  // 79 / 10 = 7.9  то это целочисленное деление 79 // 10 = 7  // double x1 = Convert.ToDouble(num) / 10.0;    //Через double
// int x2 = num % 10;  // остаток от деления 79 полностью смогли поделить на 10 но остаток остался 9 
// if (x1 > x2)
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {x1}");
// else if (x1 < x2)
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {x2}");
// else
//     System.Console.WriteLine($"Число: {x1} равно числу: {x2}");

// for (int i=1;i<=10;i++)     //Используется чаще всегда когда цикл работает известное количество раз
// {
//     System.Console.Write($"{i} ");
// }



// ************************************************************************************************
// Задача 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Clear();
// int num = new Random().Next(100, 1000);
// System.Console.WriteLine($"Было сгенерировано случайное число: {num}");
// int num1 = num / 100;
// int num2 = num % 10;
// System.Console.Write($"Ввывод без второго числа {num1}{num2}");



// ************************************************************************************************
// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//           Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!); //   Тоже самое Convert.ToInt32(Console.ReadLine())
// int result = num1 % num2;
// if (result == 0)
//     System.Console.WriteLine("Кратно");
// else
//     System.Console.WriteLine($"Не кратно, остаток: {result}");



// ************************************************************************************************
// Задача 4. Напишите программу, которая принимает на вход число 
//           и проверяет, кратно ли оно одновременно 7 и 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// if (num % 7 == 0 && num % 23 == 0) // один аперсент (&) проверяет два условия, а один & если первый 'нет' то уходим в else
//         System.Console.WriteLine($"{num} -> Да");
// else
//     System.Console.WriteLine($"{num} -> Нет");




// ************************************************************************************************
// Задача 5. Напишите программу, которая принимает на вход вда числа и
//           проверяет, являеися ли одно число квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

// System.Console.WriteLine("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// if (num1 * num1 == num2 || num2 * num2 == num1) // || если одно из них сработает то будет 'да'
//     System.Console.WriteLine($"{num1}, {num2} -> да");
// else 
//     System.Console.WriteLine($"{num1}, {num2} -> нет");




// ************************************************************************************************
// Задача 6. Напишите программу, которая выводит случайное любое число удалить вторую цифру слева на права этого числа.
// Например:
// 456236 -> 46236
// 78255 -> 7255
// 918321 -> 98321

// System.Console.WriteLine("Введите люое число: ");
// int numFirst = int.Parse(Console.ReadLine()!);
// int numSecond = numFirst;
// int check = 1;
// if (numFirst >= 99)
// {
//     while (numSecond > 9)
//     {
//         numSecond /= 10;
//         check *= 10;
//     }
//     numFirst = numFirst % (check / 10);
//     System.Console.WriteLine($"Получилось число: {numSecond}{numFirst}");
// }
// else
//     System.Console.WriteLine("Ввели неправильно число");




//******************************************************ПРАКТИЧЕСКОЕ ЗАДАНИЕ*****************************



// ************************************************************************************************
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите 3х значое число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (99 < num && num <= 999)
// {
//     num = num / 10 % 10;
//     System.Console.WriteLine($"Ваше число: {num}");
// }
// else
//     System.Console.WriteLine("Вы ввели не правильное число");



// ************************************************************************************************
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num >= 100)
// {
//     while (num >= 100)
//     {
//         num /= 10;
//     }
//     System.Console.WriteLine(num %= 10);
// }
// else
//     System.Console.WriteLine("Третьей цифры нет");



// ************************************************************************************************
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (1 <= num && num <= 5)
//     System.Console.WriteLine("Нет");
// else if (num == 6 || num == 7)
//     System.Console.WriteLine("Да");
// else
//     System.Console.WriteLine("Вы ввели не правильный день недели");


// ************************************************************************************************
// Задача необязательная 4: на входе целое или вещественное число, надо удалить вторую цифру слева целой части этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

// System.Console.WriteLine("Введите число: ");
// double numFirst = Convert.ToDouble(Console.ReadLine());
// int numSecond = (int)numFirst;
// int check = 1;
// if (numFirst >= 99)
// {
//     while (numSecond > 9)
//     {
//         numSecond /= 10;
//         check *= 10;
//     }
//     numFirst = numFirst % (check / 10);
//     System.Console.WriteLine($"Получилось число: {numSecond}{numFirst}");
// }
// else
//     System.Console.WriteLine("Ввели неправильно число");



// ************************************************************************************************
// Задача необязательная 5:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

// System.Console.WriteLine("Введите количество программистов: ");
// int developerNumbers = Convert.ToInt32(System.Console.ReadLine());
// int sum = developerNumbers;
// sum / = 10;
// sum % = 10;
// if (sum == 1 || developerNumbers%10 == 0 )
//     System.Console.WriteLine(developerNumbers + " программистов");
// else if (developerNumbers%10 == 1)
//     System.Console.WriteLine(developerNumbers + " программист");
// else if (2 >= developerNumbers%10 || developerNumbers%10 <= 4)
//     System.Console.WriteLine(developerNumbers + " программиста");
// else if (5 <= developerNumbers%10  || developerNumbers%10 <= 8 )
//     System.Console.WriteLine(developerNumbers + " программистов");




// *******************************************************ПРОДОЛЖЕНИЕ
// Задача №7. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X != 0 и Y != 0 и выдаёт номер четверти полоски, в которой находится это точка.

// void CheckKoord(int x, int y) // void что-то делает, но ничего не возвращает
// {
//     if (x > 0 && y > 00)
//         System.Console.WriteLine("Это четверть № 1");
//     else if (x > 0 && y < 0)
//         System.Console.WriteLine("Это четверть № 4");
//     else if (x < 0 && y < 0)
//         System.Console.WriteLine("Это четверть № 3");
//     else if (x < 0 && y > 0)
//         System.Console.WriteLine("Это четверть № 2");
//     else
//         System.Console.WriteLine("Точка находится на координатной оси");
// }

// int CheckKoord2(int x, int y) // int что-то делает, но что-то возвращает
// {
//     int result = 0;
//     if (x > 0 && y > 00)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result = 4;
//     else if (x < 0 && y < 0)
//         result = 3;
//     else if (x < 0 && y > 0)
//         result = 2;
//     return result;
// }


// Console.Clear();
// System.Console.WriteLine("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord2(x, y);
// System.Console.WriteLine($"Это четверть № {CheckKoord2(x,y)}");




// ************************************************************************************************
// Задача № 8
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой ветверти (x и y).

// void CheckKoord(int num)
// {
//     if (num == 1)
//         System.Console.WriteLine("X > 0, Y > 0");
//     else if (num == 2)
//         System.Console.WriteLine("X < 0, Y > 0");
//     else if (num == 3)
//         System.Console.WriteLine("X < 0, Y < 0");
//     else if (num == 4)
//         System.Console.WriteLine("X > 0, Y < 0");
//     else
//         System.Console.WriteLine("Такой четверти нет");
// }

// string CheckKoord2(int num)
// {
//     string result = "";
//     if (num == 1)
//         result = "X > 0, Y > 0";
//     else if (num == 2)
//         result = "X < 0, Y > 0";
//     else if (num == 3)
//         result = "X < 0, Y < 0";
//     else if (num == 4)
//         result = "X > 0, Y < 0";
//     return result;
// }


// System.Console.WriteLine("Введите четверь: ");
// int x = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x);
// System.Console.WriteLine(CheckKoord2(x));




// ************************************************************************************************
// Задача № 9
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// Например:
// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21

// System.Console.WriteLine("Введите координаты Xa: ");
// int xa = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Xb: ");
// int xb = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Ya: ");
// int ya = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Yb: ");
// int yb = int.Parse(Console.ReadLine()!);
// int x = (xa - xb) * (xa - xb);
// int y = (ya - yb) * (ya - yb);
// int xy = x + y;
// System.Console.WriteLine(xy);
// double result = Math.Sqrt(xy);

// System.Console.WriteLine(result);
// Math.Round (имя переменной, кол-во чисел после запятой)





// ************************************************************************************************
// Задача № 10
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int check = 0;
// int result = 0;
// while (check != num)
// {
//     result = result + 1;
//     System.Console.Write($"{result * result} ");
//     check++;
// }

// Через for

// System.Console.WriteLine($"Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Таблици квадратов чисел от 1 до {n}: ");
// for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine($"{i} в квадрате = {Math.Pow(i, 2)}");
// }




// ************************************************************Практическое задание***********************
// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int numbGadf(int num)
// {
//     int num2 = num / 1000;
//     int num3 = num % 10;
//     int num4 = (num / 10) % 10;
//     string result1 = $"{num3}{num4}";
//     string result2 = $"{num2}";
//     if (result1 == result2)
//         System.Console.WriteLine("Да");
//     else
//         System.Console.WriteLine("Нет");
//     return num;

// }


// System.Console.WriteLine("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// numbGadf(num1);



// ************************************************************************************************
// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// void NumResult(int xa, int xb, int ya,int yb, int za,int zb)
// {
//     int num1 = (xa-xb)*(xa-xb);
//     int num2 = (ya-yb)*(ya-yb);
//     int num3 = (za-zb)*(za-zb);
//     int result = num1 + num2 + num3;
//     double finishResult = Math.Sqrt(result);
//     System.Console.WriteLine(finishResult);
// }


// System.Console.WriteLine("Введите координаты Xa: ");
// int xa = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Xb: ");
// int xb = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Ya: ");
// int ya = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Yb: ");
// int yb = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Za: ");
// int za = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите координаты Zb: ");
// int zb = int.Parse(Console.ReadLine()!);

// NumResult(xa,xb,ya,yb,za,zb);



// ************************************************************************************************
// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Result3(int n)
{
    for (int i = 1; i <= n; i++)
        System.Console.Write($"{Math.Pow(i, 3)} ");
}



System.Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Result3(n);

// ************************************************************************************************
// Задача 4 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.




// ************************************************************************************************
// Задача 5 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.