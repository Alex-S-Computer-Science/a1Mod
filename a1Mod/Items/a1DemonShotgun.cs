using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace a1Mod.Items
{
	public class a1DemonShotgun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("a1's Demon Shotgun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A shotgun used for leading demonic wars within hell.");
		}

		public override void SetDefaults() 
		{
			item.damage = 66;
			item.ranged = true;
			item.width = 60;
			item.height = 40;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 5;
			item.knockBack = 12;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 6;
			item.noMelee = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(-5, -3);
            return offset;
        }
    }
}