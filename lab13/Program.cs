try { 


    
    // Ввод координат точек A, B и C
    Console.WriteLine("Введите координаты точки A (x1, y1):");
    
    double x1 = double.Parse(Console.ReadLine());
    double y1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B (x2, y2):");
    
    double x2 = double.Parse(Console.ReadLine());
    double y2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите координаты точки C (x3, y3):");
    
    double x3 = double.Parse(Console.ReadLine());
    double y3 = double.Parse(Console.ReadLine());

    // Вычисление площади треугольника
    double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;

    // Проверка коллинеарности
    if (area == 0)
    {
        Console.WriteLine("Точки A, B и C (лежат на одной прямой).");
    }
    else
    {
        Console.WriteLine("Точки A, B и C (не лежат на одной прямой).");
    }
}
catch
{
    Console.WriteLine("Error");
}