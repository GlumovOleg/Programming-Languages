// 1 Вид
void Method1()
{
    Console.WriteLine("Автор: ...");
}
//Method1();

// 2 Вид
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст",count: 5);
//Method21(count: 5, msg: "Новый текст",);

// 3 Вид
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// 4 Вид
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {

//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf ");
// Console.WriteLine(res);

// 4.1 Вид
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf ");
//Console.WriteLine(res);

//Таблица умножения от 2 до 10
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}