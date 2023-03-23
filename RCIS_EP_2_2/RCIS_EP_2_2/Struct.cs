using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_2
{
    class Person : IDisposable
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person() { name = "Кирилл"; age = 30; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Dispose()
        {
            Console.WriteLine($"{name} был фрустрирован и уничтожен :)");
        }
    }
}
