// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с 
// клавиатуры). 
// Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.


//Объявляем функция генерации массива с размером
Console.WriteLine("Укажите размер массива:");
Console.Write("Количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] CreateRandomArray(int m, int n)
{
    int [,] randomArray = new int [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        randomArray[i,j] = new Random().Next(0, 10);
        }
    }
    return randomArray;
}


