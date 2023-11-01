using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace a1Mod.Items
{
	public class voidstaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Void Staff"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("FOR THE FUNNI");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 99999;
			item.mana = 5;
			item.magic = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.knockBack = 12;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.scale = 1.0f;
			item.shoot = mod.ProjectileType("voidshot");
			item.shootSpeed = 5f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 20, speedY * 20);
			position += offset;
			return true;
        }
	}
}