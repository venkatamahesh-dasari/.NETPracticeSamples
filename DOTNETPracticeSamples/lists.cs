using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class lists
    {
        public void list1()
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4 };
            list1.Add(5);
            Console.WriteLine("list1 capacity:"+list1.Capacity);
            Console.WriteLine("list1 count:"+list1.Count);
            foreach(int li in list1)
            {
                Console.WriteLine(li);
            }
        }
        public void list2()
        {
            List<string> list2 = new List<string>();
            list2.Add("Welcome");
            list2.Add("to");
            list2.Add("Cognine");
            Console.WriteLine("list2 capacity:" + list2.Capacity);
            Console.WriteLine("list2 count:" + list2.Count);
            foreach (string li in list2)
            {
                Console.WriteLine(li);
            }
        }
        public class user
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }
        public void list3()
        {
            List<user> users = new List<user>();
            users.Add(new user { Id = 1, Name = "Mahesh", Location = "BVRM" });
            users.Add(new user { Id = 2, Name = "suresh", Location = "HYD" });
            foreach (user u in users)
            {
                Console.WriteLine("Id:{0},\tName:{1},\tLocation{2}", u.Id, u.Name, u.Location);
            }
        }
    }
}
