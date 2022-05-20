string Method4(int count, string c)
{
    string result = String.Empty;    // Пустая строка
    for (int i = 0; i < count; i++)  // инициализация счетчика ;условие  ;увелечение счетчика
    {
    result = result + c;
    }
    return result;
}

string res = Method4(1, "Метод 4");  // 1 - количество раз ,которое собираемся печатать
Console.WriteLine(res);