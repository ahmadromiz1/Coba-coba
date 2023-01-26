using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeHD3Quiz.Classes
{
    internal class CPresiden : BioData
    {
        public CPresiden(string comp,string name, string position, Guid id, DateTime birthdate, decimal salary)
        {
            Comp = comp;
            Name = name;
            Position = position;
            ID = id;
            Birthdate = birthdate;
            Salary = salary;
        }

        public List<CManager> Manager { get; set; }

        //public CManager Manager1 { get; set; }
        //public CManager Manager2 { get; set; }
        //public CManager Manager3 { get; set; }


    }


            

       
    }

