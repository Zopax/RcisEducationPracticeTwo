namespace RCIS_EP_2_2;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите номер задания: ");

        switch (Console.ReadLine())
        {
            case "1": TaskOne();   break;
            case "2": TaskTwo();   break;
            case "3": TaskThree(); break;
            case "4": TaskFour();  break;
            case "5": TaskFive();  break;
        }
    }

    public static void TaskOne ()
    {
        List<Student> students = new List<Student>
        {
            new Student("Зара",        new DateTime(2005, 4, 22), "612"),
            new Student("Радишевский", new DateTime(2005, 4, 14), "512"),
            new Student("Злобин",      new DateTime(2005, 3, 19), "612"),
            new Student("Олейникова",  new DateTime(2005, 5, 10), "612")
        };

        for (int i = 0; i < students.Count; ++i)
        {
            Console.Write($"Студент: {students[i].surName}, " +
                        $"Дата рождения: {students[i].dateBirth}, " +
                        $"Группа: {students[i].groupNumb}, " +
                        $"Оценки: ");
            Print(students[i].perfomance);
            Console.WriteLine();
        }

        students[2].surName = "Муранов";
        students[3].dateBirth = new DateTime(2005, 3, 10);
        students[1].groupNumb = "612";

        Student studentCheck = new Student("", DateTime.Now, "");

        Console.Write("Введите фамилию студента(ки): ");
        studentCheck.surName = Console.ReadLine();

        Console.Write("Введите дату рождения студента(ки) (d.m.yyyy): ");
        studentCheck.dateBirth = Convert.ToDateTime(Console.ReadLine());

        for (int i = 0; i < students.Count; ++i)
        {
            if (students[i].surName == studentCheck.surName && students[i].dateBirth == studentCheck.dateBirth)
            {
                Console.Write($"Студент: {students[i].surName}\n" +
                    $"Дата рождения: {students[i].dateBirth}\n" +
                    $"Группа: {students[i].groupNumb}\n" +
                    $"Оценки: ");
                Print(students[i].perfomance);
                break;
            }
        }
    }

    public static void TaskTwo()
    {
        List<Train> trains = new List<Train>()
        {
            new Train("Суслово - Томск", 45, DateTime.Now),
            new Train("Суслово - Магадан", 234, new DateTime(2023, 4, 10, 14, 15, 00)),
            new Train("Суслово - Москва", 574, new DateTime(2023, 4, 11, 16, 00, 00))
        };

        for (int i = 0; i < trains.Count; ++i)
        {
            Console.WriteLine($"Название поезда: {trains[i].destinationName}, Номер: {trains[i].trainNum}");
        }

        Console.WriteLine();
        Console.Write("Введите номер поезда: ");
        int trainNum = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < trains.Count; ++i)
        {
            if (trains[i].trainNum == trainNum)
            {
                Console.WriteLine($"Название поезда: {trains[i].destinationName}\n" +
                    $"Номер: {trains[i].trainNum}\n" +
                    $"Время отправления: {trains[i].timeToStart}");
            }
        }
    }

    public static void TaskThree()
    {
        Numbs numbs = new Numbs(5, 13);

        numbs.Print(numbs.a);
        numbs.Print(numbs.b);

        numbs.a = numbs.ChangeNumb(numbs.a);
        numbs.b = numbs.ChangeNumb(numbs.b);

        Console.WriteLine($"Sum: {numbs.SumNumbs(numbs.a, numbs.b)}");

        Console.WriteLine($"Greater numb: {numbs.CompareNumbs(numbs.a, numbs.b)}");

    }

    public static void TaskFour()
    {
        Counter counter = new Counter();
        Console.Write("Введите начальное значение счетчика: ");
        counter.i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(counter.i);

        while (counter.i != 10 & counter.i < 10)
        {
            counter.Increase();
        }

        Console.WriteLine(counter.i);

        while (counter.i != 5)
        {
            counter.Reduce();
        }

        Console.WriteLine(counter.i);
    }

    public static void TaskFive()
    {
        Person tom = new Person("Том", 15);
        Person roman = new Person("Роман", 18);
        Person noname = new Person();

        try
        {
            Console.WriteLine(tom.name + ' ' + tom.age);
            Console.WriteLine(roman.name + ' ' + roman.age);
            Console.WriteLine(noname.name + ' ' + noname.age);
        }
        finally
        {
            tom.Dispose();
            roman.Dispose();
            noname.Dispose();
        }
    }

    public static void Print(int[] list)
    {
        for (int i = 0; i < list.Length; ++i)
        {
            Console.Write($"{list[i]} ");
        }
    }
}