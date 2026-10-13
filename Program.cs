// Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
// for (int i = 6; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// Задание 1.2
// double[] temps = {20.2, 21.0, 23.4, 17.9, 20.3, 15.3, 16.2};
// foreach (double temp in temps)
// {
//     Console.Write($"{temp} ");
// }
// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int k = 0;
// foreach (int price in prices)
// {
//     sum += price;
//     if (price > 100)
//     {
//         k++;
//     }
// }
// double average = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}, дороже 100: {k}");
// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int ind = 0;
// int maxi = prices[0];
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (prices[i] > maxi)
//     {
//         ind = i;
//         maxi = prices[i];
//     }
// }
// Console.WriteLine($"Минимум: {min}; Индекс самого дорогого: {ind}");
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 1; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Задание 5
// int[] num = new int[5];
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = Convert.ToInt32(Console.ReadLine());
// }
// int k = 0;
// for (int i = num.Length - 1; i >= 0; i--)
// {
//     if (num[i] % 2 == 0)
//     {
//         k++;
//     }
//     Console.Write(num[i] + " ");
// }
// Console.WriteLine($"Чётных чисел: {k}");
// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// string ind = "Не найдено";
// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// for (int i = 0; i < names.Length; i++)
// {
//     if (name == names[i])
//     {
//         ind = Convert.ToString(i);
//         break;
//     }
// }
// Console.WriteLine(ind);
// Итоговая задача. «Журнал оценок»
// int[] grades = [2, 5, 4, 2, 3, 3, 5, 4];
// Console.Write("Оценки: ");
// int sum = 0;
// int max = 0;
// int min = 6;
// int k2 = 0;
// int k5 = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write(grades[i] + "; ");
//     sum += grades[i];
//     if (grades[i] > max)
//     {
//         max = grades[i];
//     }
//     if (grades[i] < min)
//     {
//         min = grades[i];
//     }
//     if (grades[i] == 2)
//     {
//         k2++;
//     }
//     else if (grades[i] == 5)
//     {
//         k5++;
//     }
// }
// double average = (double)sum / grades.Length;
// Console.WriteLine($"Средняя оценка: {average}");
// Console.WriteLine($"Наибольшая оценка: {max}; Наименьшая оценка: {min}");
// Console.WriteLine($"Количество двоек: {k2}; Количество пятёрок: {k5}");
// if (average >= 4.5)
// {
//     Console.WriteLine("Отличник");
// } else if (average >= 3.5)
// {
//     Console.WriteLine("Хорошист");
// } else
// {
//     Console.WriteLine("Есть над чем поработать");
// }
// Дополнительное задание ★★★
int[] arr = { 1, 2, 3, 4, 5, 6 };
for (int i = 0; i < arr.Length / 2; i++)
{
    int el = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = el;
}
foreach (int n in arr)
{
    Console.Write(n + "; ");
}
