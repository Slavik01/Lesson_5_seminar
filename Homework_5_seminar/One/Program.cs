// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[size]; // выделяем память new int[size] для элементов которые введем с консоли и записываем в массив positivNumbers
int count = 0;
for (int i = 0; i < size; i++)
{
    arrayNumbers[i] = new Random().Next(100, 1000);// c 0  индекста рандомные числа
}
Console.WriteLine($"Массив: [{String.Join("; ", arrayNumbers)}]");
    for (int k = 0; k < arrayNumbers.Length; k++)
    {
        if ((arrayNumbers[k] % 2) == 0) // поиск кол-во четного числа 
        {
        count++; Console.WriteLine($"Четные числа из массива: {arrayNumbers[k]}"); // счетчик для подсчета кол-во числе и вывод чисел из массива
        }
        
        
    }

//Console.WriteLine($"Массив: [{String.Join("; ", arrayNumbers)}]");
//Console.WriteLine("Четные: " + count);

