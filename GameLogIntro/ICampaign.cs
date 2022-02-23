using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    internal interface ICampaign
    {
        public void AddCampaign(string campaignName, Games game, double discount);
        public void RemoveCampaign(string campaignName,Games game,double discount);
    }
}
