Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "H1": H1(); break;
            case "H2": H2(); break;
            case "H3": H3(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

void H1()//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
{
    Console.WriteLine("Введите число А:");
    double numA = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    double numB = double.Parse(Console.ReadLine());
    double sum = 0;
    sum = Math.Pow (numA,numB);
    Console.WriteLine(sum);
}
void H2()//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
{
    Console.WriteLine("Введите число:");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    int n = num;
    int x = 0;
    while(n > 0)
    {
        x = n % 10;
        n = n / 10;
        sum = sum + x;
    }
    Console.WriteLine(sum);
}

void H3()//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
{
    int[] array = new int[8];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}