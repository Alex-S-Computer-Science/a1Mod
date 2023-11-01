using Terraria.ID;
using Terraria.ModLoader;

namespace a1Mod.Items
{
	public class a1RitualisticSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("a1's Ritualistic Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A sword used in many rituals.");
		}

		public override void SetDefaults() 
		{
			item.damage = 666;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.2f;
			item.useTurn = true;
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