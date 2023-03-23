namespace RCIS_EP_2_2
{
    internal class Numbs
    {
        public int a { get; set; }
        public int b { get; set; }

        public Numbs(int a, int b) 
        {
            this.a = a;
            this.b = b; 
        }

        public void Print(int num)
        {
            Console.WriteLine(num);
        }

        public int ChangeNumb(int num)
        {
            Console.Write("Enter Numb: ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public int SumNumbs(int a, int b) => a + b;

        public int CompareNumbs(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
    }
}
