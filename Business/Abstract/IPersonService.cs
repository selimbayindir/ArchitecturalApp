using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAllPerson();
        void AddEntity(Person person);
        Person GetById(int id);
        void PersontToDelete(Person person);
        void DeleteById(int id);
        void Update(Person person);
        void UpdateById(int id);
        List<Person> GetByDepartmentId(int departmentId);




    }
}
