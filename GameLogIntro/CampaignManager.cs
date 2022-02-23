using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    public class CampaignManager : ICampaign
    {
        public void AddCampaign(string campaignName, Games game, double discount)
        {
            game.GameName = (game.GameName + $"(With {campaignName} Campaing)");
            game.GamePrice = game.GamePrice - discount;
        }

        public void RemoveCampaign(string campaignName, Games game, double discount)
        {
            throw new NotImplementedException();
        }
    }
}
