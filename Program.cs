internal class Program
{
    private static void Main(string[] args)
    {
        string? fullName;
        int age;
        double mathPoints;
        double physicsPoints;
        double programingPoints;
        string patternOutputLine = "ФИО: {0, 15} \nМатематика: {1, 8} \nФизика: {2, 12} \nИнформатика: {3, 7}";
        double GPA;

        
        Console.WriteLine("Введите своё ФИО: ");
        fullName = Console.ReadLine(); 

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
            mathPoints,
            physicsPoints,
            programingPoints
            );

        Console.ReadKey();

        Console.WriteLine($"Средний балл: {GPA:#.##}");
        Console.ReadKey();
    }
}