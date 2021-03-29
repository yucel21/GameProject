using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities.Concrete;

namespace GameProject.Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}
