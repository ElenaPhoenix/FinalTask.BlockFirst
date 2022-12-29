string[] CreateArray(int count) // Функция генерации массива указанной длины
{
    string[] array = new string[count];
    Console.WriteLine($"Введите поочередно с новой строки {count} обособленных элементов");
    for (int i = 0; i < count; i++) // Задаем поочередно с консоли элементы массива
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ThreeSymbolsArray(string[] array) // Функция генерации массива указанной длины
{
    var realSize = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3)
        {
            array[realSize] = value;
            realSize++;
            Console.Write($"{value} ");
        }
    }
    return array;
}


try
{
    Console.WriteLine($"Введите количество обособленных элементов, которые хотите ввести: ");
    int count = Convert.ToInt32(Console.ReadLine());

    string[] createdNewAr = CreateArray(count);
    Console.WriteLine();
    Console.WriteLine("Массив из трехзначных(и менее трех знаков) элементов: ");
    string[] threeSymbolsAr = ThreeSymbolsArray(createdNewAr);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Ошибка. Попробуйте ввести число арабскими цифрами");
}