using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeHD3Quiz.Classes
{
    internal class CManager : BioData
    {
        //public void stManager(string x)
        //{
        //    Console.WriteLine("Manager Typy : " + x);
        //    List<BioData> list = new List<BioData>();
        //   // var staf = list.Where(l => l..Contains("name")


        //}
        

        

        public CManager(string name, string position, Guid id, DateTime birthdate, decimal salary)
        {
            Name = name;
            Position = position;
            ID = id;
            Birthdate = birthdate;
            Salary = salary;
            Staff = new List<CStaff>();
        }
        public List<CStaff> Staff { get; set; }

    }
}
