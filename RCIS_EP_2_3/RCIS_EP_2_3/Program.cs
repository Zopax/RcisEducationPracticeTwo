using System.Runtime.CompilerServices;

namespace RCIS_EP_2_3;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите номер задания: ");
        switch(Console.ReadLine())
        {
            case "1": TaskOneTwo(); break;
            case "2": TaskThree(); break;
        }
    }
    public static void TaskOneTwo()
    {
        Worker worker = new Worker("Бобби", "Маерс", 200, 60);

        Console.WriteLine($"Имя работника: {worker.Name}\n" +
            $"Фамилия работника: {worker.SurName}\n" +
            $"Ставка работника за день: {worker.Rate}\n" +
            $"Кол-во отработанных дней: {worker.Days}р.");
        worker.GetSalary(worker.Rate, worker.Days);
    }

    public static void TaskThree()
    {
        Calculation calc = new Calculation("bwfbrcv");
        Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));

        calc.SetCalculationLine("erqcdfbhn");
        Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));

        calc.SetLastSymbolCalculationLine('c');
        Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));

        char lastSymbol = calc.GetLastSymbol(calc.CalculationLine);
        Console.WriteLine(lastSymbol);

        string line = calc.DeleteLastSymbol(calc.CalculationLine);
        Console.WriteLine(line);
    }
}
