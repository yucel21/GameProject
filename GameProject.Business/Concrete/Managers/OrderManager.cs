using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete.Managers
{
    public class OrderManager:CampaignManager
    {
        public void Sell()
        {
            Console.WriteLine("Ürün Satıldı");
        }
    }
}
