using System;
//PrintHeader();
//PrintHeader();
//Console.WriteLine("Основная часть программы");
//PrintFooter();
//today();
//void PrintHeader()
//{
//
//    Console.WriteLine("-_-");
//        Console.WriteLine("Лабораторная работа №13");
//        Console.WriteLine("0_0");
//    }
//    void PrintFooter()
//    {
//
//    Console.WriteLine(">_<");
//        Console.WriteLine("     Конец программы");
//        Console.WriteLine("X_X");
//    }
//    void today()
//    {
//
//    Console.WriteLine("Дата формирования отчёта(15 декабря 2025 год)//");
////
//}
//
//void PrintStudentCard(string name, int age, int number)
//{
//    Console.WriteLine($"Студент:{name}, возраст: {age}, номер группы  //{number}");
//}
//
//PrintStudentCard("Егор", 18, 2);
//PrintStudentCard("Валерия", 17, 3);
//
//double CalculateScholarship(double baseAmount, double bonusPercent)
//{
//    return baseAmount + baseAmount * bonusPercent / 100;
//}
//double result = CalculateScholarship(2000, 15);
//Console.WriteLine(result);

//double CalculateAverageGrade(int[] grades)
//{
//    int sum = 0;
//    foreach (int grade in grades)
//    {
//        sum += grade;
//    }
//    return (double)sum / grades.Length;
//}
//
//
//int[] grades = [4, 5, 3, 5, 4];
//double average = CalculateAverageGrade(grades);
//Console.WriteLine(average);
//int count = 0;
//int number = 0;
//foreach (int n in grades)
//{
//    if (n == 5) { count++; }
//    number += n;
//}
//Console.WriteLine(count);

//*
// void PrintDivider()
// {
//     Console.WriteLine("----------------");
// }


// Console.WriteLine("Вывод 1");
// PrintDivider();
// Console.WriteLine("Вывод 2");
// PrintDivider();
// Console.WriteLine("Вывод 3");
// //*B
// void IsEven (int number)
// {
//     if (number % 2 == 0){
//     Console.WriteLine("true");}
//     else
//     {
//         Console.WriteLine("false");
//     }
// }
// IsEven(4);

//** 8
// double CelsiusToFahrenheit(double celsius)
//     {
//     double f = celsius * 9 / 5 + 32;
//     return f;
// }
// Console.WriteLine(CelsiusToFahrenheit(15));


//10

bool IsaPalindrome(string word)
{
    string newword = word.ToLowerInvariant();
    for (int i = 0; i < newword.Length/2; i++)
    {
        if (newword[i] != newword[newword.Length - 1 - i]){return false;}
    }
    return true;
}
Console.WriteLine(IsaPalindrome("dssd"));
Console.WriteLine(IsaPalindrome("DWEQUYJ"));