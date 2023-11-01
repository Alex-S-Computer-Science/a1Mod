using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace a1Mod.Projectiles
{
	public class voidshot : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Void Projectile"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.magic = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 10;
			projectile.timeLeft = 6000;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;

		}


		public override void AI()
        {
			int dust = Dust.NewDust(projectile.Center, 1, 1, 199, 0f, 0f, 0, Color.Black, 1f);
			Main.dust[dust].velocity *= 0.3f;
			Main.dust[dust].scale = (float)Main.rand.Next(130, 165) * 0.013f;
			Main.dust[dust].noGravity = true;

			int dust2 = Dust.NewDust(projectile.Center, 1, 1, 12, 0f, 0f, 0, Color.Black, 1f);
			Main.dust[dust2].velocity *= 0.3f;
			Main.dust[dust2].scale = (float)Main.rand.Next(130, 165) * 0.013f;
			Main.dust[dust2].noGravity = true;
	
			Lighting.AddLight(projectile.position, 999999999999999f, 0000f, 0000f);
		}
	}
}