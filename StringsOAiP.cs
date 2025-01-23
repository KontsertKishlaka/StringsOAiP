namespace StringsOAiP;

public class StringsOAiP
{
    // Поля для задания 1
    private static string? _line;
    private static readonly string _workForCheck = "интересно";
    private static readonly string _wordToReplace = "Программирование";
    private static readonly string _targetWordReplace = "Разработка";

    // Поля для задания 2
    private static string? _userName;
    private static uint _userAge;

    public static void Main(string[] args)
    {
        // Задание 1
        Exercise1();

        // Задание 2
        Exercise2();
    }

    private static void Exercise1()
    {
        // Задание 1.1
        string _line = "Программирование на С# - это интересно!";

        // Задание 1.2
        Console.WriteLine($"Длина строки \"{_line}\" равна {_line.Length}.\n");

        // Задание 1.3
        _line.ToCharArray();
        
        for (var i = _line.Length - 1; i >= 0; i--)
            Console.Write(_line[i]);

        // Задание 1.4
        if (_line.Contains(_workForCheck))
            Console.WriteLine($"\n\nСлово \"{_workForCheck}\" есть в \"{_line}\".");
        else
            Console.WriteLine($"\n\nСлова \"{_workForCheck}\" нет в \"{_line}\".");

        // Задание 1.5
        string resultLine = _line.Replace(_wordToReplace, _targetWordReplace);
        Console.WriteLine($"\nОбновлённая строка: {resultLine}\n\n");
    }
    
    private static void Exercise2()
    {
        // Задание 2.1
        Console.WriteLine($"Введите ваше имя: ");
        _userName = Console.ReadLine();
        
        Console.WriteLine($"Введите ваш возраст: ");
        _userAge = Convert.ToUInt32(Console.ReadLine());

        // Задание 2.2
        string userInfo = string.Format("\nСТРОКА С ФОРМАТОМ\nПривет, {0}! Тебе {1} лет.", _userName, _userAge);
        Console.WriteLine(userInfo);

        // Задание 2.3
        userInfo = $"СТРОКА С ИНТЕРПОЛЯЦИЕЙ:\nПривет, {_userName}! Тебе {_userAge} лет.";
        Console.WriteLine(userInfo);
    }
}