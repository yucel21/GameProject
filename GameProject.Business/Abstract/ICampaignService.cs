using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd();
        void CampaignUpdate();
        void CampaignDelete();
    }
}
