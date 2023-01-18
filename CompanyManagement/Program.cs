using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees1 = new List<Employees>
            {
                new Employees{Id=1,Name="Mehmet",LastName="Aslan",TelNo=22222,Email="mehmet@gmail.com",UnitId=5,Wage=5000,Unit="Yönetici"},
                new Employees{Id=2,Name="Zülküf",LastName="Demir",TelNo=22222,Email="demir@gmail.com",UnitId=5,Wage=6000,Unit="Müdür "},
                new Employees{Id=3,Name="ayşe",LastName="Kaplan",TelNo=22222,Email="mehmet@gmail.com",UnitId=5,Wage=2000,Unit="Sekreter"},


            };




            var results1 = employees1.OrderBy(e=>e.Wage);  // maaşı küçükten büyüğe sıralar
            foreach (var result1 in results1)
            {
                Console.WriteLine(Messages.salary+result1.Name);

            }

            Console.WriteLine(Messages.consol);

            Employees employees = new Employees
            {
                Id = 5,
                Name = "Ahmet",
                LastName = "Şen",
                Email = "a@gmail.com",
                TelNo = 3333,
                Unit = "eleman",
                UnitId = 8,
                Wage = 2000
            };

            employees.Add(employees);

            Console.WriteLine(Messages.consol);

            List<Company> company = new List<Company>
            {
               new Company{CompanyName="ATOLLA",CompanyTlf=11111,Email="Atolla@gmail.com", Address="Diyarbakır/teknokent"},
               new Company{CompanyName="Asos",CompanyTlf=22222,Email="Asos@gmail.com", Address="Elazığ/teknokent"},
               new Company{CompanyName="Bilişi",CompanyTlf=11111,Email="bilisim@gmail.com", Address="adana/teknokent"},



            };

            var results2 = company.Where(c => c.CompanyName== Messages.Atolla && c.CompanyTlf==11111);
            foreach (var result2 in results2)
            {
                Console.WriteLine(result2.Address);

            }
            Console.WriteLine(Messages.consol);

            List<Users> users = new List<Users>()
            {
                new Users{Id=11,LastName="fatma",UsersName="karddesler",Email="fatma@gmail.com"},
                new Users{Id=11,LastName="zehra",UsersName="tas",Email="tasa@gmail.com"},

            };

            var results4 = users.FindAll(u => u.Id == 11);
            foreach (var result4 in results4)
            {
                Console.WriteLine(result4.LastName);
            }

           

          
           
            


        }
    }
}
