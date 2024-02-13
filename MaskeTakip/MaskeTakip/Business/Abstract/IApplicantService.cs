using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Abstract
{
    public interface IApplicantService
    {   
        //interfaceler bağımlılığı çözmek için kullanılır.

        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
    }
}
