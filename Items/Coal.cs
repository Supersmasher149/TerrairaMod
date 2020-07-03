using Terraria.ID;
using Terraria.ModLoader;

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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.Campfire);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}