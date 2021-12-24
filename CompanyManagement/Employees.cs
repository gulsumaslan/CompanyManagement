using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    class Employees: CompanyDepartment,IEmployeesDal
    {
        
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public int UnitId { get; set; }  //depertman ile ilişkilendirme
    
        public int Wage { get; set; } // maaş
        public int TelNo { get; set ; }

        public void Add(Employees entity)
        {
            Console.WriteLine(Messages.Added+Messages.b +entity.Id + Messages.b+Messages.Name + entity.Name +
               Messages.b+ Messages.LastName + entity.LastName + Messages.b+Messages.TelNo + entity.TelNo
                + Messages.b+ Messages.Unit + entity.Unit + Messages.b+Messages.UnitId
                +entity.UnitId + Messages.b+Messages.Wage + entity.Wage);
        }

        public List<Employees> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
