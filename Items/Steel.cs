using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace NewSword.Items
{
    public class Steel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Bar");
            Tooltip.SetDefault("steardy");
        }
        public override void SetDefaults()
        {
        }
    }
}
