// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");

int [] massiv=new int[size];

int[] array = FillArray(size);
Console.WriteLine("Введенный массив: ");
PrintArray(array);

Console.WriteLine();
// CountElem(array);
Console.WriteLine($"Количество элементов массива больше 0 равно {CountElem(array)}");

//формируем массив элементов с клавиатуры 

int [] FillArray(int len)
{
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i} элемент массива ");
        massiv[i]=Convert.ToInt32(Console.ReadLine());
    }
    return massiv;
}

//Вывод элементов массива на экран

void PrintArray(int [] array)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{array[j]}  ");
    }     
}


//Считаем количество элементов больше 0

int CountElem(int [] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0) count=count+1;
    }
    return count;

}
