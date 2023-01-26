using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeHD3Quiz.Classes
{
    internal class CStaff : BioData
    {

        public CStaff(string name, string position, Guid id, DateTime birthdate, decimal salary)
        {
            Name = name;
            Position = position;
            ID = id;
            Birthdate = birthdate;
            Salary = salary;
        }
        
    }
}
