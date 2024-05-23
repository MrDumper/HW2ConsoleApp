internal class Program
{
    private static void Main(string[] args)
    {
        string? fullName;
        string? email;
        int age;
        double mathPoints;
        double physicsPoints;
        double programingPoints;
        string patternOutputLine = "ФИО: {0, 15} \nEmail: {1, 13} \nМатематика: {2, 8} \nФизика: {3, 12} \nИнформатика: {4, 7}";
        double GPA;

        
        Console.WriteLine("Введите своё ФИО: ");
        fullName = Console.ReadLine();

        Console.WriteLine("Введите свой Email: ");
        email = Console.ReadLine();

        Console.WriteLine("Введите свой возраст: ");     
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите последовательно свои баллы по: \nМатематике, физике, программированию");            
        mathPoints = Convert.ToDouble(Console.ReadLine());                        
        physicsPoints = Convert.ToDouble(Console.ReadLine());          
        programingPoints = Convert.ToDouble(Console.ReadLine());

        GPA = (mathPoints + physicsPoints + programingPoints)/3;

        Console.WriteLine(
            patternOutputLine,
            fullName,
            email,
            mathPoints,
            physicsPoints,
            programingPoints
            );

        Console.ReadKey();

        Console.WriteLine($"Средний балл: {GPA:#.##}");
        Console.ReadKey();
    }
}