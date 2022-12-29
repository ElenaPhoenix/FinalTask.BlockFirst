string[] CreateArray(int count) // Функция генерации массива указанной длины
{
    string[] array = new string[count];
    Console.WriteLine($"Введите поочередно с новой строки {count} обособленных элементов");
    for (int i = 0; i < count; i++) // Задаем поочередно с консоли элементы массива
    {
        array[i] = Console.ReadLine();
    }
    //for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}"); // Выводим все элементы массива
    return array;
}


try
{
    Console.WriteLine($"Введите количество обособленных элементов, которые хотите ввести: ");
    int count = Convert.ToInt32(Console.ReadLine());

    string[] createdNewAr = CreateArray(count);

}
catch
{
    Console.WriteLine("Ошибка. Попробуйте ввести число арабскими цифрами");
}