try
{
    Console.WriteLine($"Введите количество обособленных элементов, которые хотите ввести: ");
    int count = Convert.ToInt32(Console.ReadLine());

}
catch
{
    Console.WriteLine("Ошибка. Попробуйте ввести число арабскими цифрами");
}