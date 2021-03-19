using GameSalesApp.Abstract;
using GameSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası başladı" + " " + campaign.CampaignDiscount + "'e varan indirimler " + " " + campaign.CampaignDuration + "Tarihleri arasında.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Kampanyası sonra erdi.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "Kampanyası  süresi"+ " " + campaign.UpdateTime + " " + "uzatılmıştır");
        }
    }
}
