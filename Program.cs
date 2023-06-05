Console.Write("Введите первый член прогрессии: ");
double first = double.Parse(Console.ReadLine());

Console.Write("Введите разность/знаменатель прогрессии: ");
double diff = double.Parse(Console.ReadLine());

Console.Write("Введите номер последнего члена: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Выберите способ решения (1 - через циклы, 2 - через формулы): ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        if (diff == 0)
        {
            Console.WriteLine("Ошибка! Разность/знаменатель не может быть равен нулю.");
            break;
        }

        double sumArith = first;
        double sumGeom = first;
        double cur = first;

        for (int i = 2; i <= n; i++)
        {
            cur += diff;

            sumArith += cur;
            sumGeom *= diff;
        }

        Console.WriteLine("Сумма арифметической прогрессии = {0}", sumArith);
        Console.WriteLine("Сумма геометрической прогрессии = {0}", sumGeom);

        break;

    case 2:
        double an = first + (n - 1) * diff;

        if (diff == 0)
        {
            Console.WriteLine("Сумма арифметической прогрессии = {0}", first * n);
            Console.WriteLine("Ошибка! Знаменатель должен быть не равен нулю.");
            break;
        }

        double sumArith2 = (first + an) * n / 2;
        double sumGeom2 = first * (Math.Pow(diff, n) - 1) / (diff - 1);

        Console.WriteLine("Сумма арифметической прогрессии = {0}", sumArith2);
        Console.WriteLine("Сумма геометрической прогрессии = {0}", sumGeom2);

        break;

    default:
        Console.WriteLine("Ошибка! Введите 1 или 2.");
        break;
}
   