using GameProject.Business.Concrete.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.ServiceAdapters;
using GameProject.Entities.Concrete;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager = new MemberManager(new KpsServiceAdapter());
            memberManager.Add(new Member
            {
                IdentityNumber = 222122,
                FirstName = "Yücel",
                LastName = "Taşkıran",
                Id = 1,
                BirthYear = 1988,

            });
        }
    }
}
