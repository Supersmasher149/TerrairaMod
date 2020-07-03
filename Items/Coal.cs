using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace NewSword.Items
{
    public class Coal : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("");
            Tooltip.SetDefault("dinosaur");
        }
        public override void SetDefaults()
        {
            item.value = 100;
            item.rare = ItemRarityID.Blue;
            item.width = 40;
            item.height = 40;
            item.maxStack = 999;
        }
    }
}
