using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogIntro
{
    internal interface IBuyGame
    {
        void Buy(Games game,Player player);
    }
}
