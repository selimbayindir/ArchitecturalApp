﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _persondal;

        public PersonManager(IPersonDal persondal)
        {
            _persondal = persondal;
        }

        public void AddEntity(Person person)
        {
            _persondal.Add(person);
        }

        public void DeleteById(int id)
        {
            var result = _persondal.Get(p => p.Id == id);
            _persondal.Delete(result);

        }

        public List<Person> GetAllPerson()
        {
           return _persondal.GetAll();
        }

        public Person GetById(int id)
        {
           return _persondal.Get(p=>p.Id==id);
           
        }

 
        public void PersontToDelete(Person person)
        {
             _persondal.Delete(person);
        }
    }
}
