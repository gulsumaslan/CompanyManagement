using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    interface IEmployeesDal:IRepository<Employees>
    {
        public int TelNo { get; set; }
    }
}
