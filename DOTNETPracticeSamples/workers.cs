using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNETPracticeSamples
{
    public class workers
    {
        public int wno { get; set; }
        public string wname { get; set; }
        public string wjob { get; set; }
        public int wsalary { get; set; }
        public string wgender { get; set; }
        public int wage { get; set; }
        public static List<workers> GetWorkers()
        {
            return new List<workers>()
            {
                new workers{wno=1,wname="Smith",wjob="Manger",wsalary=30000,wgender="Male",wage=30},
                new workers{wno=2,wname="dev",wjob="accountant",wsalary=20000,wgender="Female",wage=28},
                new workers{wno=3,wname="scoot",wjob="Manger",wsalary=35000,wgender="Male",wage=35},
                new workers{wno=4,wname="babu",wjob="fieldofficer",wsalary=15000,wgender="Male",wage=28},
                new workers{wno=5,wname="sam",wjob="accountant",wsalary=25000,wgender="Female",wage=32},
                new workers{wno=6,wname="krish",wjob="fieldofficer",wsalary=20000,wgender="Male",wage=30}

            };
        }
    }
}
