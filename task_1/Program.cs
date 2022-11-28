Console.Clear();

int dataEntryXY (string str)
{
    Console.Write (str);

    int number = int.Parse(Console.ReadLine());

    return number;
}

void findXY (int x)
{
    if (x == 1) Console.WriteLine ("X > 0, Y > 0");

    if (x == 2) Console.WriteLine ("X < 0, Y > 0");

    if (x == 3) Console.WriteLine ("X < 0, Y < 0");

    if (x == 4) Console.WriteLine ("X > 0, Y < 0");
}


int x = dataEntryXY ("Введите номер квадранта: ");

findXY (x);
