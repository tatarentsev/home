// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int Array ()
{

    int[] arr = new int [len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0, len);
    }
    

    int max = arr[0];
    for (int i = 0; i < len; i++) // поиск максимального числа
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else
        {
            max = max;
        }
    }


    int min = arr[0];
    for (int i = 0; i < len; i++) // поиск минимального числа
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            min = min;
        }
    }

    return max - min;    
}

Console.WriteLine(Array());