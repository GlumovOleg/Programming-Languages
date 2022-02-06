Console.Write("Введите имя пользователя: ");
String nameStr = Console.ReadLine()!;

if(nameStr!.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(nameStr);
}