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
        void AddEntity(Person person);
        Person GetById(int id);
        void PersontToDelete(Person person);
        void DeleteById(int id);
        List<Person> GetAllPerson();

    }
}
