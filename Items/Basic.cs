﻿using Terraria.ID;
using Terraria.ModLoader;

namespace NewSword.Items
{
    public class Basic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Basic Item");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Green;
            item.value = 10;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}