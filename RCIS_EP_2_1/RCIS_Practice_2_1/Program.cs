namespace RCIS_Practice_2_1;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите номер задания: ");
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a) 
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
        }
    }

    public static void Task1()
    {
        string? jStr = "aabbccd";
        string? sStr = "abd";
        int count = 0;
        
        for (int i = 0; i < sStr.Length; i++) 
        {
            for (int j = 0; j < jStr.Length; ++j)
            {
                if (jStr[j] == sStr[i])
                {
                    ++count;
                }
            }
        }

        Console.WriteLine(count);
    }

    public static void Task2()
    {
        List<int> candidates = new List<int>() { 10, 1, 2, 7, 6, 1, 5 };
        int target = 8;
        candidates.Sort();

        TaskTwoFunc(new List<int>(), candidates, target, new List<List<int>>());
    }

    static void TaskTwoFunc(List<int> combination, List<int> candidates, int target, List<List<int>> result)
    {
        if (combination.Sum() == target)
        {
            bool isSpecial = true;

            for (int i = 0; i < result.Count; ++i)
            {
                if (Enumerable.SequenceEqual(result[i], combination))
                {
                    isSpecial = false;
                }
            }

            if (isSpecial)
            {
                result.Add(combination);
                Console.Write($"[");

                for (int i = 0; i < combination.Count; ++i)
                {
                    Console.Write($" {combination[i]} ");
                }

                Console.WriteLine($"]");
            }
        }

        if (combination.Sum() >= target) return;

        for (int i = 0; i < candidates.Count; ++i)
        {
            var newArray = new List<int>();

            for (int k = i + 1; k < candidates.Count; ++k)
            {
                newArray.Add(candidates[k]);
            }

            var reCombination = new List<int>(combination) { candidates[i] };
            TaskTwoFunc(reCombination, newArray , target, result);
        }
    }

    public static void Task3()
    {
        List<int> nums = new List<int>() { 1, 2, 3, 4 };
        bool check = false;

        for (int i = 0; i < nums.Count; ++i)
        {
            for (int j = 0; j < nums.Count - 1; ++j)
            {
                if (i == j)
                {
                    ++j;
                }

                if (nums[i] == nums[j])
                {
                    check = true;
                    break;
                }
            }

            if (check == true)
            {
                break;
            }
        }

        Console.WriteLine(check);
    }
}
