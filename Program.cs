// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }

// Console.WriteLine($"Общее количество букв: {subject.Length}");

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }
// System.Console.WriteLine($"Средний балл - {sum / grades.Length}");

// double average = (double)sum / grades.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средний балл: {average:F2}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int counter = 0;

// foreach (string student in students)
// {
//     counter++;
//     Console.WriteLine(student);
// }

// Console.WriteLine($"Всего учеников: {counter}");

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
// }

// foreach (int p in points)
// {
//     Console.WriteLine(p);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задача А
// int[] numbers = { 1, 2, 3, 4, 5 };
// int sum = 0;

// foreach (int n in numbers)
// {
//     Console.WriteLine(n);
//     sum += n;
// }

// Console.WriteLine($"Сумма: {sum}");

// // Задача Б

// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// foreach (string day in days)
// {
//     Console.WriteLine(day + "!");
// }

// // Задача В
// string word = "Программирование";
// int count = 0;
// string gl = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

// foreach (char c in word)
// {
//     foreach (char v in gl)
//     {
//         if (c == v)
//         {
//             count++;
//             break; 
//         }
//     }
// }

// Console.WriteLine($"Гласных букв: {count}");
// Задача Г

// int[] grades = { 3, 5, 4, 5, 2 };
// int max = 0;

// foreach (int g in grades)
// {
//     if (g > max)
//     {
//         max = g;
//     }
// }

// Console.WriteLine($"Наибольшая оценка: {max}");
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//                                Задачи
// Вариант 1 

// int[] temperatures = { 20, 15, 26, 8, 13, 9, 21 };
// int sum = 0;
// foreach (int temp in temperatures)
// {
//     sum += temp;

// }
// System.Console.WriteLine($"Средняя температура - {sum / temperatures.Length}");

// // Вариант 7
// int[] grades = { 4, 5, 5, 5, 5, 3, 2 };
// int counter = 0;
// foreach (int grade in grades)
// {
//     if (grade == 5)
//     {
//         counter++;
//     }
// }
// System.Console.WriteLine($"Пятерок всего - {counter}");

// Вариант 8
// string word = "Хакер в реках";

// for (int i = word.Length - 1; i >= 0; i--)
// {
//     Console.Write(word[i]);
// }



// string[] names = { "Вась", "Василий", "Василек" };
// int[] grades = { 2, 3, 5 };
// string maxName = "";
// int max = 0;
// int sum = 0;
// for (int i = 0; i < names.Length; i++)
// {
//     System.Console.WriteLine($"{names[i]} - {grades[i]}");
//     if (max < grades[i])
//     {
//         max = grades[i];
//         maxName = names[i];
//     }
//     sum += grades[i];
// }
// System.Console.WriteLine($"Средний балл по классу - {sum / grades.Length}");
// System.Console.WriteLine($"Ученик с максимальной оценкой - {maxName}");
