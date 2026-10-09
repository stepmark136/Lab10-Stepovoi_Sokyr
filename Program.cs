string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}

Console.WriteLine($"Общее количество букв: {subject.Length}");

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;

foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;
}

double average = (double)sum / grades.Length;
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Средний балл: {average:F2}");