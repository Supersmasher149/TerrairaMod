using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace NewSword.Items
{
    public class basicItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Basic Item");
        }
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = 2;
            item.value = 10;
            item.maxStack = 999;
        }
    }
}
