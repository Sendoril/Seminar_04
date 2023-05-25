Console.WriteLine("Привет пользователь!");
Console.WriteLine("Выбери что ты хочешь сделать:");
Console.WriteLine("Задача №1: цикл, возводящий в степень");
Console.WriteLine("Задача №2: сумма цифр в числе");
Console.WriteLine("Задача №3: массив из 8 элементов и вывод на экран");
int chose;
chose = Convert.ToInt32(Console.ReadLine());
switch (chose)
{
    case 1:
        Console.Write("Какое число ты хочешь возвести?: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("В какую степень?: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = 1;
    if (b<1)
        Console.Write("Число B должно быть натуральным\n");
    else
 {
        while (b!=0)
        {
        c = c * a;
        b = b - 1;
 }
        Console.Write($"Твой результат: {c}");
 }
        break;
    case 2:
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int len = Length(number);
        Console.Write($"Сумма цифр в числе {number} равно: {Sum(number,len)}");

        int Length(int number)
 {
        int index = 0;
        while (number > 0)
 {
        number /= 10;
        index++;
 }
        return index;
 }

        int Sum(int number, int len)
 {
        int sum = 0;
        for (int i = 1; i <= len; i++)
 {
        sum += number % 10;
        number /= 10;
 }
        return sum;
 }
        break;
    case 3:
        int[] randomArray = new int[8];

        for (int i = 0; i < 8; i++)
 {
        randomArray[i] = new Random().Next(1,99);
        Console.Write(randomArray[i] + " ");
 }
        break;    
    default:
        Console.WriteLine("Выберете варианты 1-3");
        break;
}
//Конец