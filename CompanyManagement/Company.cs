using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    class Company:ICompanyDal
    {
        public string CompanyName { get; set; }
        public int CompanyTlf { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void Add(Company entity)
        {
            Console.WriteLine(Messages.Added+entity);
        }

        public List<Company> GetList()
        {
               List<Company> companies = new List<Company>();
               return companies;
        }


    }
}
