using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace a1Mod.Items
{
	public class a1Tool : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("a1's Multi-purpose Tool"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A mysterious liquid that bends and contorts into many shapes, mostly tools in this case.");
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.pick = 150;
			item.hammer = 150;
			item.axe = 30;
			item.useTurn = true;
			item.scale = 0.8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}