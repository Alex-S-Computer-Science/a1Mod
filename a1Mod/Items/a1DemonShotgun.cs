using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace a1Mod.Items
{
	public class a1DemonShotgun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("a1's Demon Shotgun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A shotgun used by a1 during his takeover of hell.");
		}

		public override void SetDefaults() 
		{
			item.damage = 66;
			item.ranged = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.knockBack = 0.2f;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.scale = 1.0f;
			item.shoot = mod.ProjectileType("a1Projectile");
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 5f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			return true;
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