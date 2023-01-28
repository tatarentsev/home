// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());


int Array ()
{
    int sum = 0;
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0, len);
        Console.WriteLine($"Элемент списка: {arr[i]} ---- индекс({i})");
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
    

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Array()}");



// Проверка - вывод 19


// int sum = 0;
// int[] arr = {3, 7, 23, 12};
// for (int i = 0; i < arr.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sum += arr[i];
//     }
// }

// Console.WriteLine(sum);