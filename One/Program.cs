//Задача 31: Задайте массив из 12 элементов, заполненный 
//случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных 
//и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//сумма положительных чисел равна 29, сумма отрицательных равна -20.

int [] array = new int[12];

int size = array.Length;

int resualtPositiv = 0;
int resualtNegativ = 0;

index = 0;
while (index < size)
{
    array[i] = new Random().Next(-9, 10);
}

for (int startIndex = 0; startIndex < size; startIndex++)
{
    if (array[startIndex] > 0)
    {
        resualtPositiv += array{startIndex};
    }
    else
    {
        resualtNegativ += array{startIndex};
    }
}
