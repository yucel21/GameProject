using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstract;
using GameProject.Business.ServiceAdapters;
using GameProject.Entities.Concrete;

namespace GameProject.Business.Concrete.Managers
{
    public class MemberManager:IMemberService
    {
        private IKpsService _kpsService;

        public MemberManager(IKpsService kpsService)
        {
            _kpsService = kpsService;
        }

        public void Add(Member member)
        {
            if (_kpsService.ValidateUser(member)==false)
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kayıt oldu");
                Console.ReadLine();
            }
            
        }

        public void Update(Member member)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }

        public void Delete(Member member)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }
    }
}
