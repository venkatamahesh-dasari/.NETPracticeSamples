using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace DOTNETPracticeSamples
{
    public class students
    {
        public int sno { get; set; }
        public string sname { get; set; }
        public string branch { get; set; }
    }
    public class colleges:IEnumerable
    {
        List<students> student = new List<students>();
        public void add(students st)
        {
            student.Add(st);
        }
        public int count
        {
            get { return student.Count; }
        }
        public students this[int index]
        {
            get
            {
                return student[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new collegesIEnumerator(this);
        }
    }
    public class collegesIEnumerator : IEnumerator
    {
        colleges coll;
        int currentindex;
        students currentstudent;
        public collegesIEnumerator(colleges colle)
        {
            coll = colle;
            currentindex = -1;
        }
        public object Current
        {
            get
            {
                return currentstudent;
            }
        }

        public bool MoveNext()
        {
            if (++currentindex >= coll.count)
                return false;
            else
                currentstudent = coll[currentindex];
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    public class studentdata
    {
        static void Main(string[] args)
        {
            colleges college = new colleges();
            college.add(new students { sno=1,sname="Mahesh",branch="CSE"});
            college.add(new students { sno = 2, sname = "Sampath", branch = "MECH" });
            college.add(new students { sno = 3, sname = "Madhu", branch = "CSE" });
            college.add(new students { sno = 4, sname = "Veerababu", branch = "CIVIL" });
            college.add(new students { sno = 5, sname = "Avinash", branch = "CIVIL" });
            foreach (students data in college)
            {
                Console.WriteLine(data.sno+" "+data.sname+" "+data.branch);
            }
        }
    }
}
