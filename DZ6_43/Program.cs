// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//  задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите к1: ");
float k1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите к2: ");
float k2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1: ");
float b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
float b2= Convert.ToInt32(Console.ReadLine());

float x=0;
float y=0;
if(k1==k2 && b1==b2) 
{
    Console.WriteLine("Прямые совпадают");
    
}
else if (k1==k2 ) 
{
    Console.WriteLine("Прямые паралельны");
    
}



//Поиск точки пересечения
float [] InterSecktionY1Y2(float k1, float k2, float b1, float b2)
{
    float [] interxy=new float[2];
    {    
    interxy[0]=(b2-b1)/(k1-k2);
    interxy[1]=k2*(b2-b1)/(k1-k2)+b2;
    }    
    return interxy;
}

//Вывод элементов массива на экран

void PrintArray(float [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}  ");
    }     
}

 if (k1!=k2 && b1!=b2 ) 
{
{
float [] array = InterSecktionY1Y2(k1, k2, b1, b2);
Console.WriteLine($"координаты пересечения x= {array[0]}   y= {array[1]}:  ");
}
}

