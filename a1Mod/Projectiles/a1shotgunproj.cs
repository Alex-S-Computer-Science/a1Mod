using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace a1Mod.Projectiles
{
	public class a1shotgunproj : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("a1 Shotgun Projectile"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.ranged = true;
			projectile.width = 4;
			projectile.height = 20;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 10;
			projectile.timeLeft = 600;
			projectile.ignoreWater = false;
			projectile.tileCollide = true;
			projectile.scale = 0.7f;
			projectile.extraUpdates = 1;
		}


		public override void AI()
        {
			projectile.aiStyle = 0;
	
			Lighting.AddLight(projectile.position, 2f, 0f, 0f);
			Lighting.Brightness(1, 1);
		}
        public override void Kill(int timeLeft)
        {
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 21, 0.8f, 0.8f);
        }
    }
}