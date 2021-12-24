using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    interface IRepository<T>
    {
        List<T> GetList(); // YolLADIĞIN CLASS sııflarını listeler
        void Add(T entity); // T ye göre ekleme işlemi yapar.
    }
}
