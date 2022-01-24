HashSet<int> hs = new();
bool flag = false;
bool flag1 = false;
int number;
string input;
string key = "1";

while (key != "n")
{
    Console.WriteLine("Введите число");
    input = Console.ReadLine();
    flag1 = int.TryParse(input, out number);

    while (flag1 != true)
    {
        Console.WriteLine("Введите число");
        input = Console.ReadLine();
        flag1 = int.TryParse(input, out number);
    }

    if (hs.Contains(number))
    {
        Console.WriteLine($"Число {number} уже существует");
    } else
    {
        hs.Add(number);
        Console.WriteLine($"Число {number} успешно сохранено");
    }

    Console.WriteLine($"Хотите продолжить? y/n");
    key = Console.ReadLine();
}