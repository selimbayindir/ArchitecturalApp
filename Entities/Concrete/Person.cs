using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person:BaseCommon,IEntity
    {
        public Person()
        {

        }
        public Person(string name, string lastName, int companyId, int departmentId)
        {
            Name = name;
            LastName = lastName;
            CompanyId = companyId;
            DepartmentId = departmentId;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }

    }
}
