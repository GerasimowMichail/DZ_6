// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , 
// является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов 
// треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите 1-е положительное целое число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е положительное целое число");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-e положительное целое число");
double c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//могут быть ли сторонами треугольника заданные числа
bool Triangle(double a, double b, double c)
{
    bool flag = false;
    if ((a + b) > c && (b + c) > a && (a + c) > b) flag = true;
    return flag;
}
//проверяем является ли треугольник прямоугольным
bool  Rectangular(double [] massiv)
{
    bool flagRectangular = false;
    for (int i=0; i<massiv.Length; i++)
    {
          if ((massiv[i])==90) flagRectangular = true;
          else flagRectangular=false;
    }
      return flagRectangular;
}



//Вычисляем периметр
double Perimetr(double a, double b, double c)
{
    double per = a + b + c;
    return per;
}
// Вычисляем площадь треугольника
double Ploshad(double ar1, double ar2, double ar3)
{
    double polPer = (ar1 + ar2 + ar3) / 2;
    double ploshad = Math.Sqrt((polPer * (polPer - a) * (polPer - b) * (polPer - c)));
    return ploshad;
}
//Вычисляем углы треугольника
//Угол возвращаем массив значений
double [] Angle(double a, double b, double c)
{
    double[] ang = new double[3];
    ang[0] = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    ang[1] = Math.Acos((b * b + a * a - c * c) / (2 * b * a)) * 180 / Math.PI;
    ang[2] = Math.Acos((c * c + a * a - b * b) / (2 * c * a)) * 180 / Math.PI;
    return ang;
}
//Вывод на экран
void PrintArray(double [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}  ");
    }     
}
//Тело программы

if (Triangle(a, b, c))
{
    Console.WriteLine("Это треугольник");//проверка на треугольник или нет
    double perimert = Perimetr(a, b, c);
    Console.WriteLine($"Периметр треугольника = {Perimetr(a, b, c)}"); //Периметр
    //Выводим значение угла 1, 2,3 
    Console.WriteLine("Углы треугольника: ");
    double[] alfa = Angle(a, b, c);
    PrintArray(alfa); // выводим углы треугольника
    if(Rectangular(alfa)) Console.WriteLine("Треугольник прямоугольный"); // проверка на прямоугольность
     //Считаем площадь
     Console.WriteLine();
   Console.WriteLine($"Площадь треугольника {Ploshad(a, b, c)}");
   
Console.WriteLine();

   if (a==b || a==c|| b==c) Console.WriteLine("Треугольник равнобедренный");// проверка на равнобедренность
    if (a==b && a==c && b==c) Console.WriteLine("Треугольник равносторонний"); // проверка на равностороннесть
    if (Rectangular(alfa)) Console.WriteLine("Тругольник прямоугольный");  //Console.WriteLine("Треугольник прямоугольный");
    
}
else Console.WriteLine("фигура не может быть треугольником");
