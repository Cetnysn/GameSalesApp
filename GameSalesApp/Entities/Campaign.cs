using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesApp.Entities
{
    public class Campaign: IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignDuration { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDiscount { get; set; }
        public string UpdateTime { get; set; }

    }
}
