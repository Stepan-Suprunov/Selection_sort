// Сортировка выбором


/* 
[6, 15, 2, 9, -3]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
[6, 15, 9]
MIN = 6
6 < 15
6 < 9
MIN = 6
[-3, 2, 6, 15, 9]
[15, 9]
MIN = 15
15 < 9
MIN = 9
[-3, 2, 6, 9, 15]
*/

Console.WriteLine("Введите колличество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

for (int i = 0; i < array.Length-1; i++)
{
    int min_index = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] < array[min_index]) min_index = j;
    }

    int temp = array[i];
    array[i] = array[min_index];
    array[min_index] = temp;
}

Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");