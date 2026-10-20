PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();
today();

void PrintHeader()
{
    Console.WriteLine("-_-");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("     Конец программы");
    Console.WriteLine("X_X");
}

void today()
{
    Console.WriteLine("Дата формирования отчёта(15 декабря 2025 год)");
}

void PrintStudentCard(string name, int age, int number)
{
    Console.WriteLine($"Студент:{name}, возраст: {age}, номер группы  {number}");
}

PrintStudentCard("Егор", 18, 2);
PrintStudentCard("Валерия", 17, 3);

