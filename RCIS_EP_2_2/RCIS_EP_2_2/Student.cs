namespace RCIS_EP_2_2
{
    public class Student
    {
        public string? surName { get; set; }
        public DateTime dateBirth { get; set; }
        public string? groupNumb { get; set; }
        public int[] perfomance { get; }

        public Student(string? surName, DateTime date, string? gNumb)
        {
            this.surName = surName;
            dateBirth = date;
            groupNumb = gNumb;
            perfomance = Perfomance();
        }

        ~Student() { }

        public int[] Perfomance()
        {
            Random rnd = new Random();
            int[] per = new int[5];

            for (int i = 0; i < 5; ++i)
            {
                per[i] = rnd.Next(2, 5);
            }

            return per;
        }

    }
}
