using KodeHD3Quiz.Classes;
using System;

namespace KodeHD3Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BioData> bioData = new List<BioData>();
            Guid obj = Guid.NewGuid();

            //presiden -error
            //DateTime bd = new DateTime(1999, 09, 09);
            //string Bd = Convert.ToString(bd);
            //bioData.Add(new BioData() {
            //    ID=obj,
            //    Name="Romiz",
            //    companyName="KodeH",
            //    Salary = 100000000,
            //    Bod = 
            // });

            //presiden            
            CPresiden p = new CPresiden("KodeR","Romiz", "President", Guid.NewGuid(), new DateTime(1999, 9, 9), 100000000);

            //public CManager(string name, string position, Guid id, DateTime birthdate, decimal salary)
            CManager m1 = new CManager("Jasmin", "Manager IT", Guid.NewGuid(), new DateTime(2000, 2, 2), 80000000);
            CManager m2 = new CManager("Jarot", "Manager Finance", Guid.NewGuid(), new DateTime(2001, 1, 1), 70000000);
            CManager m3 = new CManager("Juliaha", "Manager SDM", Guid.NewGuid(), new DateTime(2002, 2, 2), 60000000);

            //public CStaff(string name, string position, Guid id, DateTime birthdate, decimal salary)
            CStaff s1 = new CStaff("Juli", "Staff Finance", Guid.NewGuid(), new DateTime(2002, 2, 2), 50000000);
            CStaff s2 = new CStaff("Juni", "Staff SDM", Guid.NewGuid(), new DateTime(2002, 2, 2), 50000000);

            //list manager
            List<CManager> list = new List<CManager>();
            list.Add(m1);
            list.Add(m2);
            list.Add(m3);

            //list staf
            List<CStaff> listStaf = new List<CStaff>();
            listStaf.Add(s1);
            listStaf.Add(s2);

            /* -------------OutPut D Sini--------------- */
            /*Presiden*/
            //PrintPres();

            /*Manager - input m1/m2/m3 */
            var Pmanager = m2;
            //PrintManager();

            /*Staff - input s1/s2*/
            //PrintStaf(s2);




            /* --------------------------------------------- */


            void PrintPres()
            {
                PDataP(p);
                foreach (var x in list)
                {
                    Console.WriteLine($"Name {x.Name} -ID {x.ID} ");
                }
            }
            void PDataP(CPresiden p)
            {
                Console.WriteLine("ID: " + p.ID);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Position: " + p.Position);
                Console.WriteLine("Birthdate: " + p.Birthdate.ToShortDateString());
                Console.WriteLine("Salary: " + p.Salary);
                Console.WriteLine("Company:  " + p.Comp);
                Console.WriteLine("List Staf :");
            }


            void PrintManager()
            {
                MDataP(Pmanager);
                if (Pmanager.Position == "Manager IT")
                {
                    Console.WriteLine("Tidak memiliki staf di bawahi");
                }
                else if (Pmanager.Position == "Manager Finance")
                {
                    foreach (var x in listStaf)
                    {
                        if (x.Position == "Staff Finance")
                        {
                            Console.WriteLine($"Name {x.Name} -ID {x.ID} ");
                        }
                    }
                }
                else
                {
                    foreach (var x in listStaf)
                    {
                        if (x.Position == "Staff SDM")
                        {
                            Console.WriteLine($"Name {x.Name} -ID {x.ID} ");
                        }
                    }
                }
            }
            void MDataP(CManager p)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Position: " + p.Position);
                Console.WriteLine("ID: " + p.ID);
                Console.WriteLine("Birthdate: " + p.Birthdate.ToShortDateString());
                Console.WriteLine("Salary: " + p.Salary);
                //Console.WriteLine("Company:  " + p.);
                Console.WriteLine("List Staf :");
            }

            void PrintStaf(CStaff p)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Position: " + p.Position);
                Console.WriteLine("ID: " + p.ID);
                Console.WriteLine("Birthdate: " + p.Birthdate.ToShortDateString());
                Console.WriteLine("Salary: " + p.Salary);
                //Console.WriteLine("Company:  " + p.);
                //Console.WriteLine("List Staf :");
            }


        }
        //cari solusi di panggil gak mau
        
    }
}