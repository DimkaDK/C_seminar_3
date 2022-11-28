Console.Clear();

int dataEntryXY (string str)
{
    Console.Write (str);

    int number = int.Parse(Console.ReadLine());

    return number;
}

void findQuadrant (int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine ("Это первый квадрант");

    if (x < 0 && y > 0) Console.WriteLine ("Это второй квадрант");

    if (x < 0 && y < 0) Console.WriteLine ("Это третий квадрант");

    if (x > 0 && y < 0) Console.WriteLine ("Это четвертый квадрант");
}






int x = dataEntryXY ("Введите координаты X = : ");


int y = dataEntryXY ("Введите координаты Y = : ");


findQuadrant (x, y);
