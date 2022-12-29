string[] CreateArray(int count) // Функция генерации массива указанной длины
{
    string[] array = new string[count];
    Console.WriteLine($"Введите поочередно с новой строки {count} обособленных элементов");
    for (int i = 0; i < count; i++) // Задаем поочередно с консоли элементы массива
    {
        array[i] = Console.ReadLine();
    }
    for (int j = 0; j <= count; j++)
    {
        if (j == 0) Console.Write($"[\"{array[j]},\" ");
        else if (j == count - 1) Console.Write($"\"{array[j]}\"]");
        else if (j < count - 1) Console.Write($"\"{array[j]}\", ");
    }
    Console.WriteLine();
    return array;
}

string[] ThreeSymbolsArray(string[] array) // Функция генерации массива указанной длины
{
    int arLength = 0;
    foreach (var el in array)
    {
        if (el.Length <= 3)
            arLength++;
    }

    string[] result = new string[arLength];
    int i = 0;
    foreach (var el in array) //вместо array мб любой enumerable
    {
        if (el.Length <= 3)
        {
            result[i] = el;
            i++;
        }
    }

    if (result.Length < 1) Console.WriteLine("[]"); // Вывод массива
    else
    {
        Console.Write("[");
        for (int j = 0; j <= result.Length; j++)
        {
            if (j == 0) Console.Write($"\"{result[j]}\", ");
            else if (j == result.Length - 1) Console.Write($"\"{result[j]}\"");
            else if (j < result.Length - 1) Console.Write($"\"{result[j]}\",");
        }
        Console.Write("]");
    }
    return result;
}


try
{
    Console.WriteLine($"Введите количество обособленных элементов больше 1, которые хотите ввести: ");
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