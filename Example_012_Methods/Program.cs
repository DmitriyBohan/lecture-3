// Вид 1
void Method1()
{
    Console.WriteLine("Метод 1");
}
Method1();

// Вид 2
void Method2(string msq)
{

    Console.WriteLine(msq);
}
Method2(msq: "Mетод 2");

void Method21(string msq, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}
Method21("Mетод 2.1", 1);                 // 1 - соличество раз ,которое собираемся печатать
Method21(msq: "Метод 2.1.1", count: 1);   // 1 - количество раз ,которое собираемся печатать
Method21(count: 1, msq: "Meтод 2.1.2");   // 1 - количество раз ,которое собираемся печатать

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();

Console.WriteLine("Mетод 3  " + year);

// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;    // Пустая строка
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(1, "Метод 4");  // 1 - количество раз ,которое собираемся печатать
Console.WriteLine(res);