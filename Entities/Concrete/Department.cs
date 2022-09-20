using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department:BaseCommon,IEntity
    {
        public Department()
        {

        }
        public string Name { get; set; }

    }
}
