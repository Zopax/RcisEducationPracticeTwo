namespace RCIS_EP_2_3
{
    public class Worker
    {
        private string name;
        private string surName;
        private int rate;
        private int days;

        public string Name
        {
            get { return name; }
        }
        public string SurName
        {
            get { return surName; }
        }

        public int Rate
        {
            get { return rate; }
        }

        public int Days
        {
            get { return days; }
        }

        public Worker(string name, string surName, int rate, int days)
        {
            this.name = name;
            this.surName = surName;
            this.rate = rate;
            this.days = days;
        }

        public void GetSalary(int rate, int days) => Console.WriteLine($"Зарплата сотрудника: {rate * days}р.");

    }
}
