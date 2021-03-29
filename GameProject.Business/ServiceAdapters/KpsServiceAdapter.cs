using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.KpsServiceReference;
using GameProject.Entities.Concrete;

namespace GameProject.Business.ServiceAdapters
{
    public class KpsServiceAdapter:IKpsService
    {
        public bool ValidateUser(Member member)
        {
            return false; //deneme olarak sonuc dönmesi için

            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrula(member.IdentityNumber,
            //    member.FirstName.ToUpper(), member.LastName.ToUpper(),
            //    member.BirthYear);
        }
    }
}
