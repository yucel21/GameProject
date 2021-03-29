using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstract;

namespace GameProject.Business.Concrete.Managers
{
    public class CampaignManager:ICampaignService
    {
        public void CampaignAdd()
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void CampaignDelete()
        {
            Console.WriteLine("Kampanya Silindi");
        }
    }
}
