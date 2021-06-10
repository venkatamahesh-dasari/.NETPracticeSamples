using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace samplespractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class queryclass
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> querysyntax = from num in numbers
                                           where num > 5
                                           select num;
            foreach (var i in querysyntax)
                Console.WriteLine(i);
            Console.WriteLine("*********************");
            var methodsyntax = numbers.Where(num1 => num1 > 6);
            foreach (var i in methodsyntax)
                Console.WriteLine(i);
            Console.WriteLine("*********************");
            var mixedsyntax = (from num2 in numbers
                               where num2 > 5
                               select num2).Max();
            Console.WriteLine("Max value:" + mixedsyntax);
            Console.WriteLine("*********************");
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mahesh",Gender="Male"},
                new Employee(){Id=2,Name="pranitha",Gender="Female"},
                new Employee(){Id=3,Name="sampath",Gender="Male"}
            };
            IEnumerable<Employee> query = from emp1 in emp
                                          where emp1.Gender == "Male"
                                          select emp1;
            foreach (var i in query)
                Console.WriteLine("Id=" + i.Id + " " + "Name=" + i.Name + " " + "Gender=" + i.Gender);
            Console.WriteLine("*********************");
            IQueryable<Employee> query1 = emp.AsQueryable().Where(x => x.Gender == "Female");
            foreach (var i in query1)
                Console.WriteLine("Id=" + i.Id + " " + "Name=" + i.Name + " " + "Gender=" + i.Gender);
            Console.WriteLine("*********************");
            IEnumerable<int> EvenNumbers = Enumerable.Where(numbers, n => n % 2 == 0);
            foreach (var i in EvenNumbers)
                Console.WriteLine("Even Numbers:" + i);
        }
    }
}
