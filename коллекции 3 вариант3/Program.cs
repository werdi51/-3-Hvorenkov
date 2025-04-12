using System.Collections;

class Program
{
    static ArrayList vectors = new ArrayList(); // Хранилище векторов (по условию ArrayList)

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить вектор");
            Console.WriteLine("2. Сложить два вектора");
            Console.WriteLine("3. Вычесть два вектора");
            Console.WriteLine("4. Скалярное произведение");
            Console.WriteLine("5. Длина вектора");
            Console.WriteLine("6. Косинус угла между векторами");
            Console.WriteLine("7. Вывести все векторы");
            Console.WriteLine("8. Выход");

            Console.Write("Выберите действие: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddVector();
                    break;
                case 2:
                    Operate((v1, v2) => v1 + v2, "Сумма векторов");
                    break;
                case 3:
                    Operate((v1, v2) => v1 - v2, "Разность векторов");
                    break;
                case 4:
                    Operate((v1, v2) => Vector.DotProduct(v1, v2).ToString(), "Скалярное произведение");
                    break;
                case 5:
                    ShowVectorLength();
                    break;
                case 6:
                    Operate((v1, v2) => Vector.CosAngle(v1, v2).ToString(), "Косинус угла");
                    break;
                case 7:
                    PrintAllVectors();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        }
    }

    static void AddVector()
    {
        Console.Write("Введите x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Введите z1: ");
        double z1 = double.Parse(Console.ReadLine());
        Console.Write("Введите x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Введите y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Введите z2: ");
        double z2 = double.Parse(Console.ReadLine());

        vectors.Add(new Vector(x1, y1, z1, x2, y2, z2));
        Console.WriteLine("Вектор добавлен!");
    }

    static void Operate(Func<Vector, Vector, object> operation, string operationName)
    {
        if (vectors.Count < 2)
        {
            Console.WriteLine("Недостаточно векторов!");
            return;
        }

        PrintAllVectors();
        Console.Write("Выберите первый вектор (индекс): ");
        int i1 = int.Parse(Console.ReadLine());
        Console.Write("Выберите второй вектор (индекс): ");
        int i2 = int.Parse(Console.ReadLine());

        Vector v1 = (Vector)vectors[i1]; 
        Vector v2 = (Vector)vectors[i2];

        object result = operation(v1, v2);
        Console.WriteLine($"{operationName}: {result}");
    }

    static void ShowVectorLength()
    {
        if (vectors.Count == 0)
        {
            Console.WriteLine("Нет векторов!");
            return;
        }

        PrintAllVectors();
        Console.Write("Выберите вектор (индекс): ");
        int i = int.Parse(Console.ReadLine());

        Vector v = (Vector)vectors[i];
        Console.WriteLine($"Длина вектора: {v.Length()}");
    }

    static void PrintAllVectors()
    {
        if (vectors.Count == 0)
        {
            Console.WriteLine("Векторов нет!");
            return;
        }

        Console.WriteLine("\nСписок векторов:");
        for (int i = 0; i < vectors.Count; i++)
        {
            Console.WriteLine($"{i}: {vectors[i]}");
        }
    }
}